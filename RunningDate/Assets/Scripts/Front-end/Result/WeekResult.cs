using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekResult : MonoBehaviour
{
    // Start is called before the first frame update
    private string Region;
    private Calculate calculate;
    public Text result; 
    private void Start()
    {
        calculate = GameObject.Find("Manager").GetComponent<Calculate>();
        Region=this.gameObject.name;
        result.text = calculate.CalculateResult(0).ToString();
    }

}
