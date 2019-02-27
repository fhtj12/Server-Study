var mysql = require('mysql');

var account_db = require('../db/account');
var log_db = require('../db/log');
var errors = require('../manage/error').errors;
var sess = require('../manage/session');
var time = require('../manage/time');
var cryption = require('../manage/cryption');

function login(req_param, session_key, callback) {
    var pwd = mysql.escape(req_param.pwd);
    var login_params = [mysql.escape(req_param.id)];

    account_db.login_db(login_params, function(err, result) {
        if(err !== null) {
            return callback(err);
        } else if(result.length == 0) {
            return callback(errors.login.id_not_found);
        } else {
            if(pwd !== result[0].pwd) {
                return callback(errors.login.invalid_pwd);
            } else {
                sess.create_session(req_param, session_key, function(err, session_key) {
                    if(err !== null || err === undefined) {
                        return callback(errors.session.invalid_parameter);
                    } else {
                        log_db.update_login_log_db(result[0].uid, session_key, function(err) {
                            if(err === null || err !== undefined) {
                                return callback(null, session_key);
                            } else {
                                return callback(err);
                            }
                        });
                    }
                });
            }
        }
    });
}

function logout() {

}

// 새로운 기기로 로그인 시도시 다른 기기에서 로그아웃 시킴.
function auto_logout() {

}

// 회원 가입
function create_account(req_param, callback) {
    cryption.create_bcrypt(req_param.pwd, function(result) { // bcrpyt, callback 때문에 어쩔 수 없이 이 함수 안에 다 넣음.
        var server_time = time.get_server_datetime(); // 서버시간 가져오기

        var id = cryption.encrypt(req_param.id); // aes192
        var uid = cryption.hash(id + server_time); // sha1
        var pwd = result;
        var user_name = cryption.encrypt(req_param.username);
        var first_name = cryption.encrypt(req_param.firstname);
        var last_name = cryption.encrypt(req_param.lastname);
        var email = cryption.encrypt(req_param.email);
        var phone = cryption.encrypt(req_param.phone);
        var national_code = mysql.escape(req_param.national_code);
        var create_params = [id, uid, pwd, user_name, first_name, last_name, email, phone, national_code, server_time];
        for(var idx in create_params) { // null 검사
            if(create_params[idx] === undefined || create_params[idx] === null) {
                return callback(errors.account.invalid_parameter);
            }
        }

        find_id(id, function(result) {
            if(!result) {
                return callback(errors.account.duplicate);
            } else {
                account_db.create_account_db(create_params, function(err) {
                    if(err !== null || err === undefined) {
                        return callback(err);
                    } else {
                        return callback('ok');
                    }
                });
            }
        });
    });
}

function update_account(req_param, callback) {
    var id = mysql.escape(req_param.id);
    var pwd = mysql.escape(req_param.pwd);
}

function delete_account(req_param, callback) {

}

function update_password(req_param, callback) {

}

// false를 반환하면 id가 중복인 것. true는 사용가능한 id
function find_id(id, callback) {
    account_db.find_id_db(id, function(err, result) {
        if(result.length == 0) {
            return callback(true);
        } else {
            return callback(false);
        }
    });
}

function find_password(req_param) {

}

module.exports = {
    login : login,
    create_account : create_account,
    update_account : update_account,
    delete_account : delete_account,
    update_password : update_password,
    find_id : find_id,
    find_password: find_password
};