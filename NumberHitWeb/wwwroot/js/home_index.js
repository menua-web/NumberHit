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