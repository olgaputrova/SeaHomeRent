//console.log("yohoho");
//ymaps.ready(init);
//var myMap;


function init(params) {
    
    console.log(params);
    //var mapPlacemarks[] = new[] MapMark,
    
    //var myGeoObjects = new ymaps.geoObjects;
    

        //// Создаем геообъект с типом геометрии "Точка".

        //myGeoObject = new ymaps.GeoObject({
        //    // Описание геометрии.
        //    geometry: {
        //        type: "Point",
        //        coordinates: [mapPlacemarks[i].latitude, mapPlacemarks[i].longitude]
        //    },
        //    // Свойства.
        //    properties: {
        //        // Контент метки.
        //        iconContent: mapPlacemarks[i].markNumber,
        //        hintContent: mapPlacemarks[i].shortText
        //    }
        //}, {
        //    // Опции.
        //    // Иконка метки будет растягиваться под размер ее содержимого.
        //    preset: 'islands#blackStretchyIcon',
        //    iconColor: '#3b5998',
        //    // Метку можно перемещать.
        //    draggable: true
        //});
        //myGeoObjects.add(myGeoObject);

    var myMap = new ymaps.Map("map", {
        center: [44.40121, 34.0095],
        zoom: 14
    }, {
        searchControlProvider: 'yandex#search'
    });

    
    //public static List < MapMark > GetMapMarksFromDB()
    //{
    //    var client = new MongoClient("mongodb://localhost");
    //    var database = client.GetDatabase("SeaHome");
    //    var collection = database.GetCollection < MapMark > ("MapMarks");

    //    List < MapMark > listOfMapMarks = collection.Find(x => true).ToList();
    //    return listOfMapMarks;
    //}

    //const mongo = require('mongodb').MongoClient

    //mongo.connect(
    //    'mongodb://localhost',
    //    (err, client) => {
    //        if (err) {
    //            console.log('Connection error: ', err)
    //            throw err
    //        }

    //        console.log('Connected')
    //        const db = client.db('SeaHome')
    //        const collection = db.getCollection('MapMarks')

    //        client.close()
    //    }
    //)



    var clusterer = new ymaps.Clusterer();
    //var myPlacemark1 = new ymaps.Placemark([55.85, 60.64]);
   //var mapPlacemarks[] = new MapMark[params.length];
    //mapPlacemarks = params;
    console.log(params.marks);
    params.marks.forEach(mark => {
        console.log(mark);
        var myPlacemark = new ymaps.Placemark([mark.latitude, mark.longitude]);
        clusterer.add(myPlacemark);
    });
    //for (var i : params.Marks) {
    //}
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

    //myMap.geoObjects
    //    .add(myGeoObjects);
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