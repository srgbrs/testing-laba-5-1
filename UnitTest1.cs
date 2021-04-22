using System;
using Xunit;
using RestClient;
using System.Net.Http;
using System.Collections.Generic;

namespace ProjectTest5
{
    public class UnitTest1
    {


        [Fact]
        public async void Test1()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate1.p.rapidapi.com/language/translate/v2"),
                Headers = {
        { "x-rapidapi-key", "5a3fa96c84msh3fb75a862829e05p177f38jsn1f7a6684d174" },
        { "x-rapidapi-host", "google-translate1.p.rapidapi.com" },
                },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "q", "Hello, world!" },
        { "target", "es" },
        { "source", "en" },
    }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }

        }

        [Fact]
        public async void test2()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate1.p.rapidapi.com/language/translate/v2/detect"),
                Headers =
    {
        { "x-rapidapi-key", "5a3fa96c84msh3fb75a862829e05p177f38jsn1f7a6684d174" },
        { "x-rapidapi-host", "google-translate1.p.rapidapi.com" },
    },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "q", "English is hard, but detectably so" },
    }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }

        [Fact]
        public async void Test3()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://google-translate1.p.rapidapi.com/language/translate/v2/languages?target=ru"),
                Headers =
    {
        { "x-rapidapi-key", "5a3fa96c84msh3fb75a862829e05p177f38jsn1f7a6684d174" },
        { "x-rapidapi-host", "google-translate1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }

          
        }


    }
}
