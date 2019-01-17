var express = require('express');
var router = express.Router();

router.get('/normal', function(req, res) {
    res.send('ok');
});

router.get('secret', function(req, res) {
    res.send('ok');
});

module.exports = router;