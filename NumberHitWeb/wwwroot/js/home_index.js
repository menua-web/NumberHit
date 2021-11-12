$(document).ready(function () {

    $('.a-number').click(function () {
        
        var container = $('#number-container');
        if (container.find('a').length < 4) {
            var current = $(this).clone();
            var numbers = getNumbers();
            if ($.inArray(current.attr('numberId'), numbers) === -1) {
                current.removeClass('a-number');
                current.addClass('a-number-edit');
                container.append(current);
            }
        }
    });
})

function clearContainer() {
    $('#number-container').html('');
}

function startGame() {
    var data = { objId: 1 };
    $.ajax({
        url: '@Url.Action("PassIntFromView", "ControllerName")',
        type: "post",
        contentType: 'application/x-www-form-urlencoded',
        data: data,
        success: function (result) {
            console.log(result);
        }
    });
}

function getNumbers() {
    var container = $('#number-container');
    var numbersElements = container.find('a');
    var number = [];
    numbersElements.each(function (index, el) {
        number.push($(el).attr('numberId'))
    });
    return number;
}