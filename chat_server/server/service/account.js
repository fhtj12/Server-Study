var mysql = require('mysql');
var crypto = require('crypto');

var account_db = require('../db/account');
var log_db = require('../db/log');
var errors = require('../manage/error').errors;
var sess = require('../manage/session');
var time = require('../manage/time');

function login(req_param, req_session, callback) {
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
                sess.create_session(req_param, req_session, function(err, session_key) {
                    if(err !== null || err === undefined) {
                        return callback(errors.session.invalid_parameter);
                    } else {
                        log_db.update_login_log_db(result[0].uid, session_key, function(err) {
                            return callback(err);
                        });
                    }
                });
            }
        }
    });
}

function create_account(req_param, callback) {
    try {
        var server_time = time.get_server_datetime(); // 서버시간 가져오기

        var id = mysql.escape(req_param.id);
        var uid = crypto.createHash('sha1').update(id + server_time).digest('base64');
        var pwd =  mysql.escape(req_param.pwd);
        var email = mysql.escape(req_param.email);
        var phone = mysql.escape(req_param.phone);
        var national_code = mysql.escape(req_param.national_code);
        var create_params = [id, uid, pwd, email, phone, national_code, server_time];
    } catch(exception) {
        console.log(exception);
        return callback(errors.account.invalid_parameter);
    }

    find_id(id, function(err) {
        if(err !== null || err === undefined) {
            return callback(err);
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
}

function update_account(req_param, callback) {

}

function delete_account(req_param, callback) {

}

function update_password(req_param, callback) {

}

// false를 반환하면 id가 중복인 것. true는 사용가능한 id
function find_id(id, callback) {
    account_db.find_id_db(id, function(err, result) {
        if(result.length == 0) {
            return callback(null);
        } else {
            return callback(errors.login.id_not_found);
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