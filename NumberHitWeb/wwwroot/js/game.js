$(document).ready(function () {

})

function restartGame() {
    $.ajax({
        url: '/game/restart',
        type: "post",
        contentType: 'application/x-www-form-urlencoded',
        data: null,
        success: function (result) {
            window.location.href = '/home/index';
        }
    });
}