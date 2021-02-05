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
    public Movie Print(string name)
    {

        string query = name;
        //movie api with 5 movie search results
        string url = "https://openapi.naver.com/v1/search/movie?query=" + query + "&display=1";

        //requesting the http from given api url
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Headers.Add("X-Naver-Client-Id", "pD3FuZnjsrm1nXgP8isw");
        request.Headers.Add("X-Naver-Client-Secret", "wZOutcA8wg");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //checking the status of the http response if its okay or not
        string status = response.StatusCode.ToString();
        if (status == "OK")
        {
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            //changing string into json objects
            JObject obj = JObject.Parse(text);
            JArray array = JArray.Parse(obj["items"].ToString());
            //declaring the list for the movie results
            List<movieLists> Movies = new List<movieLists>();



            foreach (JObject itemObj in array)
            {
                //Adding movie results to the declared list
                Movies.Add(new movieLists(itemObj["title"].ToString(), itemObj["subtitle"].ToString(), itemObj["director"].ToString(), itemObj["userRating"].ToString()));
            }
            Debug.Log("The movies are as follow !!");
            Movie m = new Movie();

            m.Name = Movies[0].korname;
            m.EName = Movies[0].engname;
            m.UserRating = Movies[0].ratings;
            m.DirectorName = Movies[0].director;
            return m;

            //foreach (var movie in Movies)
            // {
                
                ////showing the movie results
                //Debug.Log("Korean name : " + movie.korname);
                //Debug.Log("English name : " + movie.engname);
                //Debug.Log("Director name : " + movie.director);
                //Debug.Log("Movie ratings : " + movie.ratings);
                //Debug.Log("==================================");
            // }


        }
        else
        {
            Debug.Log("Error " + status);
            return null;
        }
    }

    //declaring class for saving movie information
    public class movieLists
    {
        public string korname;
        public string engname;
        public string director;
        public string ratings;

        //Constructor
        public movieLists(string korname, string engname, string director, string ratings)
        {
            this.korname = korname;
            this.engname = engname;
            this.director = director;
            this.ratings = ratings;
        }

    }

}
