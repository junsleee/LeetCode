﻿using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AzureStorage
{
    public class BlobStorage
    {
        BlobServiceClient client;
        private string _connectionString =
            @"DefaultEndpointsProtocol=https;AccountName=vc0316;AccountKey=EtncGrpA7RkLfhOz5WuaA57bZ7jR4Gx/TgYfmGidUxfJL1qNdiTxnoca6GPK24Qi4NWUmFk5Mib2+AStC/IjOA==;EndpointSuffix=core.windows.net";
        public BlobStorage()
        {

        }
        public void CreateFolder(string folderName)
        {
            var containerClienter = new BlobContainerClient(_connectionString, folderName);
            containerClienter.CreateIfNotExists();
        }
        public int EnumerateFolderContent(string folderName)
        {
            var containerClienter = new BlobContainerClient(_connectionString, folderName);

            return containerClienter.GetBlobs().Count();
        }
        public List<string> DownloadFolderContent(string folderName, int count)
        {
            var downloadedFiles = new List<string>();
            var containerClienter = new BlobContainerClient(_connectionString, folderName);
            var listToDownload = containerClienter.GetBlobs().Take(count).ToList();
            foreach (var item in listToDownload)
            {
                containerClienter.GetBlobClient(item.Name)
                    .DownloadTo($@"C:\download\{item.Name}");
                downloadedFiles.Add($@"c:\download\{item.Name}");
            }
            return downloadedFiles;
        }
    }
}
