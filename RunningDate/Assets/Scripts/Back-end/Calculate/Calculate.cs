using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    #region Movie info
    //select in naver
    private string MovieName;
    //find in db
    private int Week;
    private float ReservationRate;
    private float SalesShare;
    private int Audience;
    private int Screen;
    #endregion
    #region Select Region
    private string Region;
    #endregion



    #region Select Movie
    public void SelectMovie(string name)
    {
        MovieName = name;
    }
    #endregion

    #region
    public void SelectRegion(string name)
    {

    }
    #endregion

}
