var db = require('./db');
var time = require('../manage/time');
var errors = require('../manage/error').errors;

function update_login_log(uid, session_key, callback) {
    var params = [uid, session_key, time.get_server_datetime()];
    db.db_with_transaction('INSERT INTO tbl_login_log (uid, session_key, date) VALUES (?, ?, ?)', params, function(err, result) {
        if(err === null || err === undefined) {
            return callback('ok');
        } else {
            return callback(errors.mysql_error.mysql_db_error);
        }
    });
}

module.exports = {
    update_login_log_db : update_login_log
};