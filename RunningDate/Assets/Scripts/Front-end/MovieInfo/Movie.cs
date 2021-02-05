using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movie : MonoBehaviour
{
   
    public string Name { get;  set; }
    public string EName { get;  set; }
    public string UserRating { get;  set; }
    public string DirectorName { get;  set; }

    private void Start()
    {
        if (this.gameObject.name == "MovieImage")
        {
            //Movie newMovie = nm.Print(this.gameObject.transform.GetChild(0).name);
        }
        Name=GameObject.Find("Manager").GetComponent<Calculate>().MovieName;

    }
}

