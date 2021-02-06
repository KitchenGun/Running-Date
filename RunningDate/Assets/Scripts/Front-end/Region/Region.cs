using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Region : MonoBehaviour
{
    [SerializeField]
    private Sprite[] images;
    private int level;
    [SerializeField]
    private Text text;

    private Movie movie;
    private Calculate calculate;
    private Manager m;
    private void Start()
    {
        calculate = GameObject.Find("Manager").GetComponent<Calculate>();
        m = GameObject.Find("Manager").GetComponent<Manager>();
        switch (calculate.MovieName)
        {
            case "극장판 귀멸의 칼날: 무한열차편":
                this.gameObject.GetComponent<Image>().sprite = images[0];
                text.text = "0%";
                break;
            case "명탐정 코난: 진홍의 수학여행":
                switch (this.gameObject.name)
                {
                    case "Seoul":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "25%";
                        break;
                    case "Incheon":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "22%";
                        break;
                    case "Gyeinggi":
                        this.gameObject.GetComponent<Image>().sprite = images[1];
                        text.text = "43%";
                        break;
                    case "Sejong":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "25%";
                        break;
                    case "Daejun":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "26%";
                        break;
                    case "ChungBuk":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "19%";
                        break;
                    case "Chungnam":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "21%";
                        break;
                    case "JeonBuk":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "23%";
                        break;
                    case "Jeonnam":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "18%";
                        break;
                    case "Kwangju":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "25%";
                        break;
                    case "Kangwon":
                        this.gameObject.GetComponent<Image>().sprite = images[1];
                        text.text = "30%";
                        break;
                    case "Daegu":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "25%";
                        break;
                    case "Gyeongbuk":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "26%";
                        break;
                    case "Gyeongnam":
                        this.gameObject.GetComponent<Image>().sprite = images[1];
                        text.text = "42%";
                        break;
                    case "Busan":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "22%";
                        break;
                    case "Ulsan":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "23%";
                        break;
                    case "Jeju":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "18%";
                        break;
                    case "All":
                        this.gameObject.GetComponent<Image>().sprite = images[0];
                        text.text = "28%";
                        break;
                }
                break;
        }
    }

    public void moveScene()
    {
        m.SceneLoad(3);
    }
}