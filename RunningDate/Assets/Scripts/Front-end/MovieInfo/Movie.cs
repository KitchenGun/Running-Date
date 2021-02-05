using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movie : MonoBehaviour
{
    public string Name { get; private set; }
    public int UserRating { get; private set; }
    public string DirectorName { get; private set; }

    private void Start()
    {
        Name=GameObject.Find("Manager").GetComponent<Calculate>().MovieName;
    }
}

