google.maps.event.addDomListener(window, 'load', init);

function init() {
    var mapOptionsRussia = {
        zoom: 4,
        scrollwheel: false,
        navigationControl: false,
        mapTypeControl: false,
        scaleControl: false,
        draggable: true,

        center: new google.maps.LatLng(57.569789,54.553562), // Russia

        styles: [{
            "featureType": "administrative",
            "elementType": "all",
            "stylers": [{"visibility": "on"}]
        }, {
            "featureType": "landscape",
            "elementType": "all",
            "stylers": [{"hue": "#ff0300"}, {"saturation": -100}, {"lightness": 129.33333333333334}, {"gamma": 1}, {"visibility": "on"}]
        }, {
            "featureType": "poi",
            "elementType": "all",
            "stylers": [{"hue": "#abff00"}, {"saturation": 61.80000000000001}, {"lightness": 13.800000000000011}, {"gamma": 1}, {"visibility": "on"}]
        }, {
            "featureType": "road",
            "elementType": "all",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "road.highway",
            "elementType": "all",
            "stylers": [{"visibility": "on"}, {"color": "#1fa661"}, {"weight": "0.55"}]
        }, {
            "featureType": "road.highway",
            "elementType": "labels.icon",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "road.highway.controlled_access",
            "elementType": "all",
            "stylers": [{"visibility": "on"}]
        }, {
            "featureType": "road.highway.controlled_access",
            "elementType": "labels.icon",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "road.arterial",
            "elementType": "all",
            "stylers": [{"hue": "#00b7ff"}, {"saturation": -31.19999999999996}, {"lightness": 2.1803921568627374}, {"gamma": 1}, {"visibility": "on"}]
        }, {
            "featureType": "road.local",
            "elementType": "all",
            "stylers": [{"hue": "#00B5FF"}, {"saturation": -33.33333333333343}, {"lightness": 27.294117647058826}, {"gamma": 1}, {"visibility": "on"}]
        }, {
            "featureType": "transit",
            "elementType": "all",
            "stylers": [{"visibility": "on"}]
        }, {
            "featureType": "transit.line",
            "elementType": "all",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "transit.station.airport",
            "elementType": "all",
            "stylers": [{"visibility": "on"}]
        }, {
            "featureType": "transit.station.bus",
            "elementType": "all",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "water",
            "elementType": "all",
            "stylers": [{"hue": "#00B7FF"}, {"saturation": 8.400000000000006}, {"lightness": 36.400000000000006}, {"gamma": 1}]
        }]
    };

    var mapOptionsEurope = {
        zoom: 3,
        scrollwheel: false,
        navigationControl: false,
        mapTypeControl: false,
        scaleControl: false,
        draggable: true,

        center: new google.maps.LatLng(51.1161142,18.6441863), // Europe

        styles: [{
            "featureType": "administrative",
            "elementType": "all",
            "stylers": [{"visibility": "on"}]
        }, {
            "featureType": "landscape",
            "elementType": "all",
            "stylers": [{"hue": "#ff0300"}, {"saturation": -100}, {"lightness": 129.33333333333334}, {"gamma": 1}, {"visibility": "on"}]
        }, {
            "featureType": "poi",
            "elementType": "all",
            "stylers": [{"hue": "#abff00"}, {"saturation": 61.80000000000001}, {"lightness": 13.800000000000011}, {"gamma": 1}, {"visibility": "on"}]
        }, {
            "featureType": "road",
            "elementType": "all",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "road.highway",
            "elementType": "all",
            "stylers": [{"visibility": "on"}, {"color": "#1fa661"}, {"weight": "0.55"}]
        }, {
            "featureType": "road.highway",
            "elementType": "labels.icon",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "road.highway.controlled_access",
            "elementType": "all",
            "stylers": [{"visibility": "on"}]
        }, {
            "featureType": "road.highway.controlled_access",
            "elementType": "labels.icon",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "road.arterial",
            "elementType": "all",
            "stylers": [{"hue": "#00b7ff"}, {"saturation": -31.19999999999996}, {"lightness": 2.1803921568627374}, {"gamma": 1}, {"visibility": "on"}]
        }, {
            "featureType": "road.local",
            "elementType": "all",
            "stylers": [{"hue": "#00B5FF"}, {"saturation": -33.33333333333343}, {"lightness": 27.294117647058826}, {"gamma": 1}, {"visibility": "on"}]
        }, {
            "featureType": "transit",
            "elementType": "all",
            "stylers": [{"visibility": "on"}]
        }, {
            "featureType": "transit.line",
            "elementType": "all",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "transit.station.airport",
            "elementType": "all",
            "stylers": [{"visibility": "on"}]
        }, {
            "featureType": "transit.station.bus",
            "elementType": "all",
            "stylers": [{"visibility": "off"}]
        }, {
            "featureType": "water",
            "elementType": "all",
            "stylers": [{"hue": "#00B7FF"}, {"saturation": 8.400000000000006}, {"lightness": 36.400000000000006}, {"gamma": 1}]
        }]
    };

    var russiaMap = document.getElementById('russia-map');
    var europeMap = document.getElementById('europe-map');

    var mapRussia = new google.maps.Map(russiaMap, mapOptionsRussia);
    var map = new google.maps.Map(europeMap, mapOptionsEurope);

    new google.maps.Marker({
        position: new google.maps.LatLng(55.751244, 37.618423),
        map: mapRussia,
        title: 'Москва'
    });


    new google.maps.Marker({
        position: new google.maps.LatLng(59.934116, 49.073303),
        map: mapRussia,
        title: 'Казань'
    });


    new google.maps.Marker({
        position: new google.maps.LatLng(36.543803, 32.012652),
        map: map,
        title: 'Турция'
    });

    new google.maps.Marker({
        position: new google.maps.LatLng(51.1719674, 10.4541194),
        map: map,
        title: 'Германия'
    });



}