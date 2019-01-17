var express = require('express');
var router = express.Router();

// 기능별로 서비스 모듈 쪼개기
var login = require('../service/login');
var account = require('../service/account');

router.get('/login', function(req, res) {
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