var crypto = require('crypto');

var error = require('../manage/error').errors;
var time = require('../manage/time');
var redis_route = require('../routes/redis');

// 세션 생성, 완료되면 null, 오류나면 오류코드
var create_session = function(req_param, callback) {
    try {
        var uid = req_param.uid;
        var session_key = crypto.createHash('sha1').update(uid + time.get_server_datetime()).digest('base64');
        redis_route.write_session(uid, session_key, function(result) {
            if(result) {
                return callback(null, session_key);
            } else {
                return callback(undefined);
            }
        });
    } catch (exception) {
        console.log(exception);
        callback(error.invalid_parameter);
    }
};

// 세션 있는지 체크, 있으면 null 없거나 오류나면 오류코드
var check_session = function(uid, session_key, callback) {
    redis_route.check_session(uid, session_key, function(result) {
        if(result) {
            return callback(null);
        } else {
            return callback(error.session.invalid_session);
        }
    });
};

// 세션 삭제, 완료되면 null, 오류나면 오류코드
var destroy_session = function(uid, callback) {
    redis_route.delete_session(uid, function(result) {
        if(result) {
            return callback(null);
        } else {
            return callback(error.session.invalid_session);
        }
    });
};

module.exports = {
    create_session : create_session,
    check_session : check_session,
    destroy_session : destroy_session
};