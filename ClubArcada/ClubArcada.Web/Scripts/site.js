$(document).ready(function () {
    SetWelcomeHeignt();
});

$(window).resize(function () {
    SetWelcomeHeignt();
});


$(window).scroll(function (event) {
    SetWelcomeHeignt();
});

function SetWelcomeHeignt() {
    var section = $('#sc-welcome');
    var height = $(window).height();
    section.css('height', height + "px");
    if ($(window).width() > 768)
        $('.welcome-title').css("margin-top", height / 5 + "px");
};

