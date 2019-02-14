var express = require('express');
var router = express.Router();

// 기능별로 서비스 모듈 쪼개기
var login = require('../service/login');
var account = require('../service/account');

var session = require('express-session');

// 세션 관리
var manage_session = require('../manage/session');

router.get('/login', function(req, res) {
    manage_session.create_session(req.session, function(err) {
        if(err == null) {
            res.send('ok');
        } else {
            res.send(err);
        }
    });
});

router.get('/logout', function(req, res) {
    manage_session.destroy_session(req);
    res.send('ok');
});

router.get('/duplicate_check_id', function(req, res) {
    res.send('ok');
});

router.get('/create_account', function(req, res) {
    res.send('ok');
});

router.get('/update_account', function(req, res) {
    res.send('ok');
});

router.get('/delete_account', function(req, res) {
    res.send('ok');
});

module.exports = router;