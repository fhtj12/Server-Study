var dateformat = require('date-format');

function get_server_datetime() {
    var datetime = dateformat.asString('yyyy-MM-dd hh:mm:ss', new Date());
    return datetime;
}

module.exports = {
    get_server_datetime : get_server_datetime
};