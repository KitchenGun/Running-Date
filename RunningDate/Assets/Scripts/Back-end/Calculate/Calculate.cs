using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    #region Movie info
    //select in naver
    public string MovieName;
    //find in db
    private float ThisSalesShare;
    private float BeginSalesShare;
    private int Audience;
    private int Screen;
    private string Date;
    private int week;
    #endregion
    #region Select Region
    private string Region;
    public string region;
    #endregion
    #region CalculateDate()
    private float SquaredX;
    private float[] Week;// 주차별 확률값이 저장이 됨
    #endregion
    #region weekcalculate
    /*public int weekcalculate(string value)// 연월일 추출
    {
        int a = 0;
        string[] Date_ymd = value.Split('-');
        int[] ymd = { 0, 0, 0 };
        for (int i = 0; i < 2; i++)
        {
            if (int.TryParse(Date_ymd[i], out int j))
            {
                ymd[i] = j;
            }
        }
        if (Date_ymd[0] == "2021")
        {
            if (ymd[1] == 1)
            {
                if (25 <= ymd[2])
                {
                    a = 4;
                    if (18 <= ymd[2])
                    {
                        a = 3;
                        if (11 <= ymd[2])
                        {
                            a = 2;
                            if (4 <= ymd[2])
                            {
                                a = 1;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            a = 0;
        }
        return a;
    }*/
    #endregion
    #region RetunrnInt
    public int RetunrnInt(float[] Week)
    {
        int a = 0;
        if (Week[0] < 30)
            a = 1;
            if (Week[0] < 70)
                a = 2;
            else a = 3;
        return a;
    }
    #endregion

    private void Start()
    {
        //Reset
        Week = new float[5];
    }

    #region BringFromNaverAPI
    #region Select Movie Func
    public void SelectMovie(string name)
    {
        MovieName = name;
        Debug.Log(name);
    }
    #endregion
    #endregion
    #region BringFromUI
    #region Select Region Func
    public void SelectRegion(string name)
    {
        Region = name;
        region = Region;
    }
    #endregion
    #endregion
    #region Calculate Func

    //(개봉주의 판매량과 이번 주 매출액점유율)*3.5+(관객수/상영횟수)/60 
    public void CalculateSquaredX()
    {
        // 개봉일이 1주차보다 
        
          
            SquaredX = ((ThisSalesShare + BeginSalesShare) * 3.5f) + (Audience / Screen) * (1f / 60);
            SquaredX = Mathf.Round(SquaredX * 100) * 0.01f;
        
        Debug.Log(SquaredX);
    }
    //주차별 결과값
    public float CalculateResult(int week)
    {
        for (int i = 1; i < 6; i++)
        {
            float x = Mathf.Pow(10, SquaredX);
            x = Mathf.Round(x * 100) * 0.01f;
            float y = Mathf.Pow(i, 6f) + Mathf.Pow(10, SquaredX);
            y = Mathf.Round(y * 100) * 0.01f;
            Week[i - 1] = (1 - Mathf.Round((x / y) * 10))*100;
        }
        return Week[week];
    }

    #endregion
    #region BringFromDB

    #region setThisSalesShare Func
    public void setThisSalesShare(float value)
    {
        ThisSalesShare = value;
    }
    #endregion

    #region setBeginSalesShare Func
    public void setBeginSalesShare(float value)
    {
        BeginSalesShare = value;
    }
    #endregion

    #region setAudience
    public void setAudience(int value)
    {
        Audience = value;
    }
    #endregion

    #region setScreen
    public void setScreen(int value)
    {
        Screen = value;
    }
    #endregion

    #region BeginDate
    public void BeginDate(string value)
    {
        Date = value;
    }
    #endregion
    #endregion

}
