using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

public class navermovies : MonoBehaviour
{
    public class APIExamSearchBlogg
    {

        private void Start()
        {
            Console.WriteLine("Search a movie : ");
            string query = Console.ReadLine();
            string url = "https://openapi.naver.com/v1/search/movie?query=" + query + "&display=5";


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "pD3FuZnjsrm1nXgP8isw");
            request.Headers.Add("X-Naver-Client-Secret", "wZOutcA8wg");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();
            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();
                //Console.WriteLine(text);

                //List<movieLists> m =JsonConvert.DeserializeObject<List<movieLists>>(text);
                JObject obj = JObject.Parse(text);
                JArray array = JArray.Parse(obj["items"].ToString());

                Console.WriteLine("The movies are as follow !!");

                foreach (JObject itemObj in array)
                {
                    movieLists movies = new movieLists();
                    movies.korname = itemObj["title"].ToString();
                    Console.WriteLine("Korean name : " + movies.korname);
                    movies.engname = itemObj["subtitle"].ToString();
                    Console.WriteLine("English name : " + movies.engname);
                    movies.publishDate = itemObj["pubDate"].ToString();
                    Console.WriteLine("Published Date : " + movies.publishDate);
                    movies.director = itemObj["director"].ToString();
                    Console.WriteLine("Director name : " + movies.director);
                    movies.link = itemObj["link"].ToString();
                    Console.WriteLine("Movie Link : " + movies.link);
                    Console.WriteLine("==================================");

                }

            }
            else
            {
                Console.WriteLine("Error " + status);
            }


        }
        public class movieLists
        {
            public string korname { get; set; }
            public string engname { get; set; }
            public string director { get; set; }
            public string publishDate { get; set; }
            public string link { get; set; }

        }

    }
}
