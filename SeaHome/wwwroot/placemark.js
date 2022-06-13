//console.log("yohoho");
//ymaps.ready(init);
var myMap;
var myGeoObjects = new ymaps.geoObjects;

//function update(shortText, latitude, longitude, markNumber) {
//    myGeoObject = new ymaps.GeoObject({
//        // Описание геометрии.
//        geometry: {
//            type: "Point",
//            coordinates: [latitude, longitude]
//        },
//        // Свойства.
//        properties: {
//            // Контент метки.
//            iconContent: markNumber,
//            hintContent: shortText
//        }
//    }, {
//        // Опции.
//        // Иконка метки будет растягиваться под размер ее содержимого.
//        preset: 'islands#blackStretchyIcon',
//        iconColor: '#3b5998',
//        // Метку можно перемещать.
//        draggable: true
//    });
//    myGeoObjects.add(myGeoObject);
//}

function init(params) {
    
    console.log(params);
    myMap = new ymaps.Map("map", {
        center: [44.40121, 34.0095],
        zoom: 14
    }, {
        searchControlProvider: 'yandex#search'
    }),

        // Создаем геообъект с типом геометрии "Точка".

        myGeoObject = new ymaps.GeoObject({
            // Описание геометрии.
            geometry: {
                type: "Point",
                coordinates: [44.408877, 34.004167]
            },
            // Свойства.
            properties: {
                // Контент метки.
                iconContent: '1',
                hintContent: 'студия в пгт.Симеиз'
            }
        }, {
            // Опции.
            // Иконка метки будет растягиваться под размер ее содержимого.
            preset: 'islands#blackStretchyIcon',
            iconColor: '#3b5998',
            // Метку можно перемещать.
            draggable: true
        });


    myMap.geoObjects
        .add(myGeoObject);
            //.add(myGeoObjects);
        //.add(myGeoObjects);

        //.add(myGeoObject);
        //.add(new ymaps.Placemark([44.50909, 34.175460], {
        //    balloonContent: '2'
        //}, {
        //    preset: 'islands#icon',
        //    iconColor: '#0095b6'
        //}));
   
}