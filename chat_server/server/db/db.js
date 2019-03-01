var mysql = require('mysql');
var errors = require('../manage/error').errors;

var mysql_conn = require('../conf/mysql_conn');

var db_pool = mysql.createPool(mysql_conn);

function db_with_transaction(conn, query, params, callback) {
    conn.query(query, params, function(err, result, fields) {
        if(err) {
            console.log(err);
            conn.rollback(function() {
                conn.release();
                return callback(errors.mysql_error.rollback);
            });
        } else {
            return callback(null, result);
        }
    });

    db_pool.getConnection(function(err, conn) {
        if(err) {
            console.log(err);
            return callback(errors.mysql_error.mysql_failed_get_connection);
        } else {
            conn.beginTransaction(function(err) {
                if(err) {
                    console.log(err);
                    conn.release();
                    return callback(errors.mysql_error.mysql_transaction_error);
                } else {
                    conn.query(query, params, function(err, result, fields) {
                        if(err) {
                            console.log(err);
                            conn.rollback(function() {
                                conn.release();
                                return callback(errors.mysql_error.mysql_db_error);
                            });
                        } else {
                            conn.commit(function(err) {
                                if(err) {
                                    console.log(err);
                                    conn.rollback(function() {
                                        conn.release();
                                        return callback(errors.mysql_error.mysql_db_error);
                                    });
                                } else {
                                    return callback(null, result);
                                }
                            });
                        }
                    });
                }
            });
        }
    });
}

function db_without_transaction(query, params, callback) {
    db_pool.getConnection(function(err, conn) {
        if(err) {
            console.log(err);
            return callback(errors.mysql_error.mysql_failed_get_connection);
        } else {
            conn.query(query, params, function(err, result, fields) {
                if(err) {
                    console.log(err);
                    conn.release();
                    return callback(errors.mysql_error.mysql_failed_query);
                } else {
                    conn.release();
                    return callback(null, result);
                }
            });
        }
    });
}

module.exports = {
    db_with_transaction : db_with_transaction,
    db_without_transaction : db_without_transaction
};