using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

public class navermovies : MonoBehaviour
{
    public GameObject Image;

    private void ImageSet(string url)
    {
        //Image.GetComponent<Image>().sprite=
    }

    public void Input()
    {
        Debug.Log("Search a movie : ");
        string query = "해리";
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

            Debug.Log("The movies are as follow !!");

            foreach (JObject itemObj in array)
            {
                APIExamSearchBlogg.movieLists movies = new APIExamSearchBlogg.movieLists();
                movies.korname = itemObj["title"].ToString();
                Debug.Log("Korean name : " + movies.korname);
                movies.engname = itemObj["subtitle"].ToString();
                Debug.Log("English name : " + movies.engname);
                movies.publishDate = itemObj["pubDate"].ToString();
                Debug.Log("Published Date : " + movies.publishDate);
                movies.director = itemObj["director"].ToString();
                Debug.Log("Director name : " + movies.director);
                movies.link = itemObj["link"].ToString();
                Debug.Log("Movie Link : " + movies.link); ;
            }

        }
        else
        {
            Debug.Log("Error " + status);
        }
    }

    public class APIExamSearchBlogg
    {
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
