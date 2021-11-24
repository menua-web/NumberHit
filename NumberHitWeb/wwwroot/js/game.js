$(document).ready(function () {
    $('.select-number').click(function () {

        var container = $('#select-number-container');
        if (container.find('a').length < 4) {
            var current = $(this).clone();
            var numbers = getNumber();
            var numberId = current.attr('numberId');
            if ($.inArray(numberId, numbers) === -1) {
                current.removeClass('a-number');
                current.addClass('a-number-edit');
                container.append(current);
                if (container.find('a').length == 4) {
                    $("#btnStartGame").removeAttr("disabled");
                }
            }
        }
    });
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