using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoviePoster : MonoBehaviour
{
    private Calculate calculate;
    [SerializeField]
    private Sprite[] Images; 
    private void Start()
    {
        calculate = GameObject.Find("Manager").GetComponent<Calculate>();
        switch (calculate.MovieName)
        {
            case"소울":
                this.gameObject.GetComponent<Image>().sprite = Images[0];
                break;
            case "명탐정 코난: 진홍의 수학여행":
                this.gameObject.GetComponent<Image>().sprite = Images[1];
                break;
            case "극장판 귀멸의 칼날: 무한열차편":
                this.gameObject.GetComponent<Image>().sprite = Images[2];
                break;
            case "세자매":
                this.gameObject.GetComponent<Image>().sprite = Images[3];
                break;
        }

    }
}
