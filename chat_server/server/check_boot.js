var redis = require('redis');
var redis_conn = require('./conf/redis_conn');

var mysql = require('mysql');
var mysql_conn = require('./conf/mysql_conn');

var checks = {
    'redis' : false,
    'mysql' : false
};

function check() {
    for (var check in checks) {
        if (!checks[check]) return false;
    }
    console.log('Redis and MySQL boot check complete.');
    return true;
}

function setWait() {
    if(!check()) {
        setTimeout(setWait, 300);
    }
}

var redis_client = redis.createClient(redis_conn);
redis_client.on('error', (err) => {
    if(err) {
        console.log("redis_client connect error : " + err);
    }
    process.exit(1);
}).on('ready', () => {
    console.log('redis is ready.');
    redis_client.end(false);
    checks.redis = true;
});

var mysql_client = mysql.createConnection(mysql_conn);
mysql_client.connect((err) => {
    mysql_client.end();
    if(!err) {
        console.log('mysql is ready.');
        checks.mysql = true;
    } else {
        console.log("mysql_client connect error : " + err);
        process.exit(1);
    }
});

module.exports = {
    db_server_status : checks,
    check_boot : setWait,
    redis_client : redis_client
};