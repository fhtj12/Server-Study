var express = require('express');
var app = express();
var session = require('express-session');
var redis_store = require('connect-redis')(session);
var redis_conn = require('./conf/redis_conn');

// redis, mysql 부팅 상태 체크 모듈
var check = require('./check_boot');

// 라우터 모듈 쪼개기
var chat = require('./routes/chat.js');
var account = require('./routes/account.js');

// 라우터 요청 쪼개기
app.use('/chat', chat);
app.use('/account', account);

var sess = {
    resave: false,
    saveUninitialized: false,
    secret: 'exocet',
    name: 'session_key',
    cookie: {
    httpOnly: true,
    secure: false,
    },
    store: new redis_store(redis_conn),
};

app.use(session(sess));

// 리슨
app.listen(9503, function() {
    console.log('server listening on 9503 port.');
    check.check_boot();
});