$(document).ready(function () {
    $('.teamNameHeader').click(function () {
        $(this).next().toggle();
    });

    $('.gameInfoToggle').first().css("display", 'block');
});