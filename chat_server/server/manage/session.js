var session = require('express-session');
var crypto = require('crypto');

var sha = crypto.createHash('sha1');

// 세션 생성, 완료되면 true, 오류나면 false
var create_session = function(req) {
    if(req.session.key) {
        return false;
    } else {
        sha.update(req.query.uid);
        req.session.key = sha.digest("hex");
        console.log(req.session.key);
        return true;
    }
};

// 세션 있는지 체크, 있으면 true 없으면 false
var check_session = function(req) {
    if(req.session.key) {
        return true;
    } else {
        return false;
    }
};

// 세션 삭제, 완료되면 true, 오류나면 false
var destroy_session = function(req) {
    if(check_session(req)) {
        req.session.destroy(function(err) {
            if(err) {
                console.log(err);
                return false;
            } else {
                console.log('session destroy ok.');
                return true;
            }
        });
    } else {
        console.log('invaild session');
    }
};

module.exports = {
    create_session : create_session,
    check_session : check_session,
    destroy_session : destroy_session
};