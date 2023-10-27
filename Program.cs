// See https://aka.ms/new-console-template for more information
/* Creating Scripts Container IN azure Storage account */

using Azure.Storage.Blobs;

Console.WriteLine("Hello, World!");
string connectionString = "DefaultEndpointsProtocol=https;AccountName=vitaostoragecool;AccountKey=uJO6I6ZfPP2OstDo5bbx5s8wCfmAjEGQ/0Qf2ZKBV4N169Kw0gu0J8ONhLlgfsxhRgDVZtxHOCQe+ASt20aNGg==;EndpointSuffix=core.windows.net";
string containerName = "scripts1";

BlobServiceClient blobService
     = new BlobServiceClient(connectionString);
await blobService.CreateBlobContainerAsync(containerName);
Console.WriteLine("Container Created");

