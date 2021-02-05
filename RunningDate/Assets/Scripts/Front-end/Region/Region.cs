using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region : MonoBehaviour
{
    private Movie movie;
    private string region;
    private Calculate calculate;
    private void Start()
    {
        calculate = GameObject.Find("Manager").GetComponent<Calculate>();
        movie = this.gameObject.GetComponent<Movie>();
        region = this.gameObject.name;
        calculate.SelectMovie(movie.name);
        calculate.SelectRegion(region);
        calculate.CalculateResult();
    }
}
