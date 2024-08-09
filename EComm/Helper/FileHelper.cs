using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace EComm.Helper
{
    public  static class FileHelper
    {
       

        public static async Task<string> UploadImage(IFormFile file)
        {
            string filename=Guid.NewGuid().ToString();
            // Get the connection string and container name from the configuration
            string connectionString = @"DefaultEndpointsProtocol=https;AccountName=shoppingcartstoragevr;AccountKey=80nYi94NkfSILiyPpCqnnFX4iKbCaZdkiV7Ng/EJqc7fkinYD1iPnkHsnvWmIjcdjocLYPqRCWde+AStwhR+dg==;EndpointSuffix=core.windows.net";
            string containerName = "bookphotos";

            // Create a BlobContainerClient object to interact with the specified container
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);

            // Create a BlobClient object to interact with a specific blob (the file being uploaded)
            BlobClient blobClient = containerClient.GetBlobClient(filename+file.FileName);


            MemoryStream ms = new MemoryStream();
           
                // Copy the file data to the MemoryStream
                await file.CopyToAsync(ms);
                ms.Position = 0; // Reset the stream's position to the beginning

                // Upload the file to the blob storage
                await blobClient.UploadAsync(ms);
            

            // Return the URL of the uploaded file (or any other relevant information)
            return blobClient.Uri.AbsoluteUri;
        }
        public static async Task<string> UploadUrl(IFormFile file)
        {
            string filename = Guid.NewGuid().ToString();
            // Get the connection string and container name from the configuration
            string connectionString = @"DefaultEndpointsProtocol=https;AccountName=shoppingcartstoragevr;AccountKey=80nYi94NkfSILiyPpCqnnFX4iKbCaZdkiV7Ng/EJqc7fkinYD1iPnkHsnvWmIjcdjocLYPqRCWde+AStwhR+dg==;EndpointSuffix=core.windows.net";
            string containerName = "bookurl";

            // Create a BlobContainerClient object to interact with the specified container
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);

            // Create a BlobClient object to interact with a specific blob (the file being uploaded)
            BlobClient blobClient = containerClient.GetBlobClient(filename+file.FileName);


            MemoryStream ms = new MemoryStream();

            // Copy the file data to the MemoryStream
            await file.CopyToAsync(ms);
            ms.Position = 0; // Reset the stream's position to the beginning

            // Upload the file to the blob storage
            await blobClient.UploadAsync(ms);


            // Return the URL of the uploaded file (or any other relevant information)
            return blobClient.Uri.AbsoluteUri;
        }
    }
}
