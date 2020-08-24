using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace RestClients
{
    class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string imdbID { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //using (HttpClient client = new HttpClient() )
            //{ 

            //}
            var myVal = GetMovieTitles("spiderman");
            var arko = GetArko("spiderman");
           

        }
        static string[] GetMovieTitles(string substr)
        {
            string urlTest = String.Format("https://jsonmock.hackerrank.com/api/movies/search/?Title="+substr);
            WebRequest requestObjGet = WebRequest.Create(urlTest);
            requestObjGet.Method = "GET";

            var responseObjGet = requestObjGet.GetResponse();

            string strresulttest = null;
            object json = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                var abc = sr.ReadToEnd();
                sr.Close();

                json = JsonConvert.DeserializeObject(strresulttest);
            }
            var len = strresulttest.Length;
            strresulttest = strresulttest.Substring(62,len-63);

            
            

            string[] strres = null;
            return strres;
        }

        static string[] GetArko(string str)
        {
            string[] st = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55587/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = client.GetAsync("https://jsonmock.hackerrank.com/api/movies/search/?Title="+str).Result;

                var resp = client.GetAsync("https://jsonmock.hackerrank.com/api/movies/search/?Title=" + str).Result;
                if (response.IsSuccessStatusCode)
                {
                    
                    string result = response.Content.ReadAsStringAsync().Result;

                    var len = result.Length;
                    var resultInJsonString = result.Substring(58, len - 59);

                    var jsonResult = JsonConvert.DeserializeObject<List<Movie>>(resultInJsonString);

                    var titleList = jsonResult.OrderBy(x=>x.Title).Select(x => x.Title);

                    st = titleList.ToArray();

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            return st;
        }
       
    }
}
