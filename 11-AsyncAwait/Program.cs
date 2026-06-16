using System;

await DownloadData();

Console.WriteLine("Finished");

async Task DownloadData()
{
    Console.WriteLine("Downloading...");

    await Task.Delay(3000);

    Console.WriteLine("Download Complete");
}