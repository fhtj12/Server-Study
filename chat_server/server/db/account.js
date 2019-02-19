var mysql = require('mysql');
var db = require('./db');
var log = require('./log');
var errors = require('../manage/error').errors;
var sess = require('../manage/session');

function login(req_param, req_session, callback) {
    var pwd = mysql.escape(req_param.pwd);
    var login_params = [mysql.escape(req_param.id)];

    db.db_without_transaction('SELECT * FROM account WHERE id = ?', login_params, function(err, result) {
        if(err === null || err === undefined) {
            return callback(errors.mysql_error.mysql_db_error);
        } else {
            if(pwd !== result[0].pwd) {
                return callback(errors.login.invalid_pwd);
            } else {
                sess.create_session(req_session, function(err, session_key) {
                    if(err === null || err === undefined) {
                        return callback(erros.session.invalid_parameter);
                    } else {
                        log.update_login_log(result[0].uid, session_key, function(err) {
                            return callback(err);
                        });
                    }
                });
            }
        }
    });
}

function create_account(req_param, callback) {

}

function update_account(req_param, callback) {

}

function delete_account(req_param, callback) {

}

function update_password(req_param, callback) {

}

function find_id(req_param, callback) {

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