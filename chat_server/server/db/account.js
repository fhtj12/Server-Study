var db = require('./db');
var errors = require('../manage/error').errors;

function login(params, callback) {
    db.db_without_transaction('SELECT * FROM otterchat.tbl_account WHERE id = ?', params, function(err, result) {
        if(err !== null || err === undefined) {
            return callback(errors.mysql_error.mysql_db_error);
        } else {
            return callback(null, result);
        }
    });
}

function create_account(params, callback) {
    db.db_with_transaction(
        'insert into otterchat.tbl_account (id, uid, pwd, username, firstname, lastname, email, phone, national_code, create_date) values (?,?,?,?,?,?,?,?,?,?)', params, 
        function(err) {
            return callback(err);
        });
}

function update_account(params, callback) {

}

function delete_account(params, callback) {

}

function update_password(params, callback) {

}

function find_id(params, callback) {
    db.db_without_transaction('select * from tbl_account where id=?', params, function(err, result) {
        return callback(err, result);
    });
}

function find_password(params, callback) {

}

module.exports = {
    login_db : login,
    create_account_db : create_account,
    update_account_db : update_account,
    delete_account_db : delete_account,
    update_password_db : update_password,
    find_id_db : find_id,
    find_password_db : find_password
};