using RssSubjector.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RssSubjector
{
    class Program
    {
        private readonly static HttpClient _httpClient = new HttpClient();

        private static string[] rssUrls = new string[] { "https://edi.wang/rss" };
        private static string root = Directory.GetCurrentDirectory();
        static async Task Main(string[] args)
        {
            foreach (var rssUrl in rssUrls)
            {
                // analyze
                var content = await _httpClient.GetStringAsync(rssUrl);
                Rss newRss = null;
                try
                {
                    newRss = XmlConvertExtension.DeserializeObject<Rss>(content);
                }
                catch
                {
                    Console.WriteLine($"{rssUrl} RSS订阅发生异常，请查看RSS源是否能正常访问！");
                }
                // find exsited rss
                var existRss = await FindRssAsync(Path.Combine(root, "edi.wang.xml"));

                // compare rss
                if(newRss.Channel.Items.Count == existRss.Channel.Items.Count)
                {
                    Console.WriteLine($"{rssUrl} 暂无更新!");
                }
                else
                {
                    Console.WriteLine($"请注意! {rssUrl} 有更新:" + newRss.Channel.Items[0].Title + " 发布时间:" + newRss.Channel.Items[0].PubDateString);
                }
            }
            Console.ReadLine();
        }

        static async ValueTask SaveOrUpdate(string rss)
        {
            string file = Path.Combine(root, "edi.wang.xml");
            using var stream = new StreamWriter(file);
            await stream.WriteLineAsync(rss);
        }

        static async Task<Rss> FindRssAsync(string url)
        {
            using var fileStream = new FileStream(url, FileMode.Open);
            var buffer = new byte[fileStream.Length];
            await fileStream.ReadAsync(buffer, 0, buffer.Length);
            var xml = Encoding.UTF8.GetString(buffer);
            // deserialize
            return XmlConvertExtension.DeserializeObject<Rss>(xml);
        }
    }
}
