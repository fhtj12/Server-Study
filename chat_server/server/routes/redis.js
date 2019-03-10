var redis = require("redis");
var client = redis.createClient();

// true면 세션 저장 성공, fasle면 세션 저장 실패(오류)
function write_session(uid, session_key, callback) {
    try {
        client.set(uid, session_key);
        return callback(true);
    } catch(exception) {
        return callback(false);
    }
}

// true면 클라이언트의 세션과 서버의 세션이 동일, false면 없거나 세션 갱신 필요
function check_session(uid, session_key, callback) {
    client.get(uid, function(err, reply) {
        console.log(reply);
        if(reply === session_key) {
            return callback(true);
        } else {
            return callback(false);
        }
    });
}

// true면 세션 삭제 성공, fasle면 세션 삭제 실패(오류)
function delete_session(uid, callback) {
    try {
        client.del(uid);
        return callback(true);
    } catch(exception) {
        return callback(false);
    }
}

module.exports = {
    write_session : write_session,
    check_session : check_session,
    delete_session : delete_session
};