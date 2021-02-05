using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    #region Movie info
    //select in naver
    private string MovieName;
    //find in db
    private float ThisSalesShare;
    private float BeginSalesShare;
    private int Audience;
    private int Screen;
    #endregion
    #region Select Region
    private string Region;
    #endregion
    #region CalculateDate()
    private float SquaredX;
    private float[] Week;// 주차별 확률값이 저장이 됨
    #endregion


    private void Start()
    {
        //Reset
        Week = new float[5];
    }

    #region Select Movie Func
    public void SelectMovie(string name)
    {
        MovieName = name;
    }
    #endregion

    #region Select Region Func
    public void SelectRegion(string name)
    {
        Region = name;
    }
    #endregion

    #region Calculate Func

    //(개봉주의 판매량과 이번 주 매출액점유율)*3.5+(관객수/상영횟수)*60 
    public void CalculateSquaredX()
    {
        SquaredX = ((ThisSalesShare + BeginSalesShare) * 3.5f) + (Audience / Screen) * (1f / 60);
        SquaredX = Mathf.Round(SquaredX * 100) * 0.01f;
        Debug.Log(SquaredX);
    }
    //주차별 결과값
    public void CalculateResult()
    {
        for (int i = 1; i < 6; i++)
        {
            float x = Mathf.Pow(10, (SquaredX + 1f));
            x = Mathf.Round(x * 100) * 0.01f;
            float y = Mathf.Pow(i, 6f) + Mathf.Pow(10, SquaredX);
            y = Mathf.Round(y * 100) * 0.01f;
            Week[i - 1] = Mathf.Round((x / y) * 10) * 0.1f;
            //확인용 debug log
            Debug.Log(i + "주차" + "" + Week[i - 1]);
        }
    }

    #endregion

    #region setThisSalesShare Func
    public void setThisSalesShare(float value)
    {
        ThisSalesShare = value;
    }
    #endregion


}
