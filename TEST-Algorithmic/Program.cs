using System.Net;

Console.WriteLine("Enter url[Enter = Default]:");
var url = Console.ReadLine();
if (string.IsNullOrEmpty(url))
{
    url = "https://algorithmic-dk.herokuapp.com/api/problems/get/1";
    Console.WriteLine($"[Default]{url}");
}
int counter = 0;
while (true)
{
    var watch = System.Diagnostics.Stopwatch.StartNew();
    counter++;
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    Stream resStream = response.GetResponseStream();
    watch.Stop();
    var elapsedMs = watch.ElapsedMilliseconds;

    Console.WriteLine($"[{counter}\t]Status:{response.StatusCode} Time:{elapsedMs}ms");
}