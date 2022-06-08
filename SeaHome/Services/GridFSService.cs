﻿using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SeaHome.Services
{
    public class GridFSService
    {
        public FileInfo file;
        const string conectionString = "mongodb://localhost";

        public async Task UploadImageToDBAsync(Stream stream, string name)
        {
            MongoClient client = new MongoClient(conectionString);
            IMongoDatabase database = client.GetDatabase("Images");
            IGridFSBucket gridFs = new GridFSBucket(database);
            await gridFs.UploadFromStreamAsync(name, stream);
        }

        public async Task ReplaceImage()
        {
            MongoClient client = new MongoClient(conectionString);
            IMongoDatabase database = client.GetDatabase("Images");
            IGridFSBucket gridFs = new GridFSBucket(database);
            var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, "qqq.jpg");
            var gridFileInfo = gridFs.Find(filter).FirstOrDefault();
            var id = gridFileInfo.Id;
            await gridFs.DeleteAsync(id);
            using (FileStream fs = new FileStream("E:/Projects/SeaHomeRent/SeaHome/wwwroot/boot.jpg", FileMode.Open))
            {
                await gridFs.UploadFromStreamAsync("qqq.jpg", fs);
            }
        }

        public void DownloadImageToWWWRoot(string filename)
        {
            MongoClient client = new MongoClient(conectionString);
            IMongoDatabase database = client.GetDatabase("Images");
            IGridFSBucket gridFs = new GridFSBucket(database);

            using (Stream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/wwwroot/images/")}{filename}", FileMode.Create))
            {
                //gridFs.DownloadToStreamByName("qqq.jpg", fs);
                gridFs.DownloadToStreamByName(filename, fs);
                //file = new FileInfo("boot.jpg");
                file = new FileInfo(filename);
                             
                Console.WriteLine(file.DirectoryName);



                //*пример с получением id файла и выгрузка из БД по id*
                //var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, "qqq.jpg");
                //var gridFileInfo = gridFs.Find(filter).FirstOrDefault();
                //gridFs.DownloadToStream(gridFileInfo.Id, fs);

                //*получение всех имен файлов из GridFS привязанных к базе Images*
                //var ff= gridFs.Find(Builders<GridFSFileInfo>.Filter.Empty).ToList();
                // foreach(var item in ff)
                // {
                //     Console.WriteLine(item.Filename);
                // }
            }
        }

    }
}
