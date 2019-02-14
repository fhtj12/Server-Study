var express = require('express');
var app = express();

var session = require('express-session');
var redis_store = require('connect-redis')(session);

// redis, mysql 부팅 상태 체크 모듈
var check = require('./check_boot');

// 라우터 모듈 쪼개기
var chat = require('./routes/chat.js');
var account = require('./routes/account.js');

// 라우터 요청 쪼개기
app.use('/chat', chat);
app.use('/account', account);

app.use(session({
    secret : 'Exocet', // 세션을 임의 변조하지 못하도록 하는 키. 이 키를 이용해 세션을 암호화하여 저장.
    // redis 서버 설정
    store : new redis_store({
        client : check.redis_client,
        port : 9523,
        prefix : "session:",
        db : 0
    }),
    saveUninitialized : false,
    resave : false // 변경되지 않아도 항상 저장할지 여부.(false 권장.)
}));

// 리슨
app.listen(9503, function() {
    console.log('server listening on 9503 port.');
    check.check_boot();
});