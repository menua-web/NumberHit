$(document).ready(function () {

    $('.a-number').click(function () {
        
        var container = $('#number-container');
        if (container.find('a').length < 4) {
            var current = $(this).clone();
            var numbers = getNumberCount();
            if ($.inArray(current.attr('numberId'), numbers) === -1) {
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



function clearContainer() {
    $('#number-container').html('');
    $("#btnStartGame").attr("disabled", "disabled");
}

function startGame() {
    var number = getNumber();
    var data = { userNumber: number };
    $.ajax({
        url: '/game/start',
        type: "post",
        contentType: 'application/x-www-form-urlencoded',
        data: data,
        success: function (result) {
            window.location.href = '/game/play';
        }
    });
}

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

function getNumberCount() {
    var number = getNumber();
    return number.length;
}

function getNumber() {
    var container = $('#number-container');
    var numbersElements = container.find('a');
    var number = "";
    numbersElements.each(function (index, el) {
        number += $(el).attr('numberId');
    });
    return number;
}