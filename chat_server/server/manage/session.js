var session = require('express-session');
var crypto = require('crypto');

var error = require('../manage/error').errors;

var sha = crypto.createHash('sha1');

// 세션 생성, 완료되면 null, 오류나면 오류코드
var create_session = function(req, callback) {
    try {
        sha.update(req.query.uid);
        req.session.key = sha.digest("hex");
        console.log(req.session.key);
        callback(null);
    } catch (exception) {
        console.log(exception);
        callback(error.invalid_parameter);
    }
};

// 세션 있는지 체크, 있으면 null 없거나 오류나면 오류코드
var check_session = function(req, callback) {
    try {
        if(req.session.key) {
            callback(null);
        } else {
            callback(error.invalid_session);
        }
    } catch (exception) {
        callback(error.invalid_session);
    }
};

// 세션 삭제, 완료되면 null, 오류나면 오류코드
var destroy_session = function(req, callback) {
    check_session(req, function(err) {
        if(err == null) {
            req.session.destroy(function(err) {
                if(err) {
                    console.log(err);
                    callback(err.failed_destroy_session);
                } else {
                    console.log('session destroy ok.');
                    callback(null);
                }
            });
        } else {
            console.log('invaild session');
            callback(error.invalid_session);
        }
    });
};

module.exports = {
    create_session : create_session,
    check_session : check_session,
    destroy_session : destroy_session
};