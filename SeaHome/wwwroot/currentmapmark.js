function init_1(param) {

    console.log(param);

    var myMap = new ymaps.Map("map", {
        center: [param.latitude, param.longitude],
        zoom: 16
    }, {
        searchControlProvider: 'yandex#search'
    });




    //var clusterer = new ymaps.Clusterer();
    ////var myGeoObjects = new ymaps.geoObjects();

    //console.log(params.marks);
    //params.marks.forEach(mark => {
    //    console.log(mark);
    //    var myPlacemark = new ymaps.Placemark([mark.latitude, mark.longitude], { iconContent: mark.shortText }, { preset: 'islands#darkBlueStretchyIcon' });
    //    clusterer.add(myPlacemark);
    //});

     //Создаем геообъект с типом геометрии "Точка".

    myGeoObject = new ymaps.GeoObject({
        // Описание геометрии.
        geometry: {
            type: "Point",
            coordinates: [param.latitude, param.longitude]
        },
        // Свойства.
        properties: {
            // Контент метки.
            iconContent: param.shortText
            //hintContent: 'студия в пгт.Симеиз'
        }
    }, {
        // Опции.
        // Иконка метки будет растягиваться под размер ее содержимого.
        preset: 'islands#blueStretchyIcon',
        iconColor: '#3b5998',
        // Метку можно перемещать.
        draggable: true
    });

    myMap.geoObjects.add(myGeoObject);
    //myMap.geoObjects.add(clusterer);
    //myMap.geoObjects.add(myGeoObjects);


}