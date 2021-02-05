using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekAllResult : MonoBehaviour
{
    // Start is called before the first frame update
    private string Region;
    private Calculate calculate;
    public Text[] result;
    private void Start()
    {
        calculate = GameObject.Find("Manager").GetComponent<Calculate>();
        Region = this.gameObject.name;
        result[0].text = calculate.CalculateResult(0).ToString();
        result[1].text = calculate.CalculateResult(1).ToString();
        result[2].text = calculate.CalculateResult(2).ToString();
        result[3].text = calculate.CalculateResult(3).ToString();
        result[4].text = calculate.CalculateResult(4).ToString();
    }

}
