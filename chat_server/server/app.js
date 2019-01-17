var express = require('express');
var app = express();

// 라우터 쪼개기
var chat = express.Router();
var account = express.Router();

// 라우터 파일 쪼개기
app.use('/routes/chat.js', chat);
app.use('/routes/account.js', account);

// 리슨
app.listen(9503, function() {
    console.log('server listening on 9503 port.');
});