function loadInstaroom() {
    $.get('/Home/Instagram', function (page) {
        $('#main').html(page);
    });
}

function loadCreateTravelPage() {
    $.get('/Admin/CreateTravel', function (page) {
        $('#main').html(page);
    });
}

function loadTravelPosters() {
    $.get('/Travel/Posters', function (page) {
        $('#main').html(page);
    });
}

function loadMap() {
    $.get('/Travel/Map', function (page) {
        $('#main').html(page);
    });
}


$(document).ready(function () {
    switch (document.location.hash) {
        case "#!instaroom":
            loadInstaroom();
        case "#!admin/travel/add":
            loadCreateTravelPage();
        case "#!travel/posters":
            loadTravelPosters();
        case "#!travel/world/map":
            loadMap();

    }

    $(document).on('click', '#instagram', function (e) {
        e.preventDefault();
        document.location.hash = "!instaroom";
        loadInstaroom();
    });

    $(document).on('click', '#travels', function (e) {
        e.preventDefault();
        document.location.hash = "#!travel/posters";
        loadTravelPosters();
    });

});
