function init(params) {
    
    console.log(params);
       
    var myMap = new ymaps.Map("map", {
        center: [44.40521, 34.004167],
        zoom: 14
    }, {
        searchControlProvider: 'yandex#search'
    });

    
    

    var clusterer = new ymaps.Clusterer();
    //var myGeoObjects = new ymaps.geoObjects();
    
    console.log(params.marks);
    
    params.marks.forEach(mark => {
        console.log(mark._id);
        var myPlacemark = new ymaps.Placemark([mark.latitude, mark.longitude], { iconContent: mark.shortText }, { preset: 'islands#darkBlueStretchyIcon' });
        myPlacemark.name = mark._markNumber;
        myPlacemark.events.add([
            'click'
        ], function (e) {
            console.log(mark);
            location.href = '/viewApartament/' + mark.markNumber.replaceAll('.', '_');
        });
        clusterer.add(myPlacemark);
    });

        // Создаем геообъект с типом геометрии "Точка".

        //myGeoObject = new ymaps.GeoObject({
        //    // Описание геометрии.
        //    geometry: {
        //        type: "Point",
        //        coordinates: [44.408877, 34.004167]
        //    },
        //    // Свойства.
        //    properties: {
        //        // Контент метки.
        //        iconContent: '1',
        //        hintContent: 'студия в пгт.Симеиз'
        //    }
        //}, {
        //    // Опции.
        //    // Иконка метки будет растягиваться под размер ее содержимого.
        //    preset: 'islands#blackStretchyIcon',
        //    iconColor: '#3b5998',
        //    // Метку можно перемещать.
        //    draggable: true
        //});

    myMap.geoObjects.add(clusterer);
    //myMap.geoObjects.add(myGeoObjects);

    
}