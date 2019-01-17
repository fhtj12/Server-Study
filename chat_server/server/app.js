var express = require('express');
var app = express();

// 라우터 쪼개기
var chat = require('./routes/chat.js');
var account = require('./routes/account.js');

// 라우터 파일 쪼개기
app.use('/chat', chat);
app.use('/account', account);

// 리슨
app.listen(9503, function() {
    console.log('server listening on 9503 port.');
});