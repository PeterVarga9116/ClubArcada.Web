$(document).ready(function () {
    $('.parallax-window').parallax({ imageSrc: 'http://localhost/ClubArcada.Web/Content/images/px01.jpg' });
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
};

