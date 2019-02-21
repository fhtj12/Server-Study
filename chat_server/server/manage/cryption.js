var crypto = require('crypto');
var bcrypt = require('bcrypt-nodejs');

var errors = require('../manage/error').errors;

var key = 'otter'; // 암호화, 복호화를 위한 키

// 암호화
function encrypt(string) {
    var cipher = crypto.createCipher('aes192', key);
    cipher.update(string, 'utf8', 'base64');
    return cipher.final('base64');
}

// 복호화
function decrypt(crypt) {
    var decipher = crypto.createDecipher('aes192', key);
    decipher.update(crypt, 'base64', 'utf8');
    return decipher.final('utf8');
}

// 해시
function hash(string) {
    var result = crypto.createHash('sha1').update(string).digest('base64');
    return result;
}

// 암호화할 대상 문자열 string, 반환은 완료된 hash, 오류면 null
function create_bcrypt(string, callback) {
    bcrypt.hash(string, null, null, function(err, hash) {
        if(err) {
            console.log(err);
            return callback(err);
        } else {
            return callback(hash);
        }
    });
}

// 평문 문자열 plain, 암호 crypt 반환은 같으면 true, 틀리면 false
function compare_bcrypt(plain, crypt, callback) {
    bcrypt.compare(plain, crypt, function(err, res) {
        if(res) {
            return callback(true);
        } else {
            return callback(false);
        }
    });
}

module.exports = {
    encrypt : encrypt,
    decrypt : decrypt,
    hash : hash,
    create_bcrypt : create_bcrypt,
    compare_bcrypt : compare_bcrypt
};