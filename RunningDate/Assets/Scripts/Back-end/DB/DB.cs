using UnityEngine;
using System;
using System.Data;
using System.IO;
using Mono.Data.SqliteClient;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class DB : MonoBehaviour
{
    private Calculate calculate;
    private int Audience;
    private int Screen;
    private float BeginSalesShare;
    private float ThisSalesShare;
    private string MovieName;

    int a = 0;

    void Start()
    {
        calculate = this.gameObject.GetComponent<Calculate>();
        MovieName = calculate.MovieName;

        DBConnectionCheck();

        if (MovieName == "소울")
        {
            DataBaseThisRead("Select * From All_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Busan_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Chungbuk_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Chungnam_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Daegu_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Daejeon_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Gangwon_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Gwangju_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeongbuk_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeonggi_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeongnam_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Incheon_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Jeju_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Jeonbuk_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Jeonnam_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Sejong_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Seoul_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

            DataBaseThisRead("Select * From Ulsan_1_4 WHERE Ranking LIKE 1 ");
            calsend2();

        }
        else if (MovieName == "극장판 귀멸의 칼날: 무한열차편")
        {
            DataBaseThisRead("Select * From All_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Busan_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Chungbuk_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Chungnam_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Daegu_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Daejeon_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Gangwon_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Gwangju_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeongbuk_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeonggi_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeongnam_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Incheon_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Jeju_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Jeonbuk_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Jeonnam_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Sejong_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Seoul_1_4 WHERE Ranking LIKE 2 ");
            calsend2();

            DataBaseThisRead("Select * From Ulsan_1_4 WHERE Ranking LIKE 2 ");
            calsend2();
        }
        else if (MovieName == "세자매")
        {
            DataBaseThisRead("Select * From All_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Busan_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Chungbuk_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Chungnam_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Daegu_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Daejeon_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Gangwon_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Gwangju_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeongbuk_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeonggi_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeongnam_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Incheon_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Jeju_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Jeonbuk_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Jeonnam_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Sejong_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Seoul_1_4 WHERE Ranking LIKE 3 ");
            calsend2();

            DataBaseThisRead("Select * From Ulsan_1_4 WHERE Ranking LIKE 3 ");
            calsend2();
        }
        else if (MovieName == "명탐정 코난: 진홍의 수학여행")
        {
            DataBaseThisRead("Select * From All_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Busan_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Chungbuk_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Chungnam_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Daegu_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Daejeon_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Gangwon_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Gwangju_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeongbuk_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeonggi_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Gyeongnam_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Incheon_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Jeju_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Jeonbuk_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Jeonnam_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Sejong_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Seoul_1_4 WHERE Ranking LIKE 4 ");
            calsend2();

            DataBaseThisRead("Select * From Ulsan_1_4 WHERE Ranking LIKE 4 ");
            calsend2();
        }
    }


    public void calsend2()
    {
        calculate.setThisSalesShare(ThisSalesShare);
        calculate.setAudience(Audience);
        calculate.setScreen(Screen);
    }

    void Update()
    {

    }
    #region DB파일 경로
    public string GetDBFilePath()
    {
        string str = string.Empty;
        if (Application.platform == RuntimePlatform.Android)
        {
            str = "URI=file:" + Application.persistentDataPath + "/DB.db";
        }
        else
        {
            str = "URI=file:" + Application.dataPath + "/DB.db";
        }
        return str;
    }

    #endregion
    #region DB연결체크
    public void DBConnectionCheck()
    {
        try
        {
            IDbConnection dbConnection = new SqliteConnection(GetDBFilePath());
            dbConnection.Open();
            if (dbConnection.State == ConnectionState.Open)
            {
                Debug.Log("연결성공");
            }
            else
            {
                Debug.Log("연결실패");
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
    #endregion
    #region DB 읽기
    public void DataBaseBeginRead(string query)
    {
        IDbConnection dbConnection = new SqliteConnection(GetDBFilePath());
        dbConnection.Open();
        IDbCommand dbCommand = dbConnection.CreateCommand();
        dbCommand.CommandText = query;
        IDataReader dataReader = dbCommand.ExecuteReader();
        while (dataReader.Read())
        {
            Debug.Log(dataReader.GetInt32(0) + "," + dataReader.GetString(1) + "," + dataReader.GetString(2) + ","
                + dataReader.GetFloat(3) + "," + dataReader.GetInt32(4) + "," + dataReader.GetInt32(5));

            if (dataReader.GetString(1) == "소울")
            {
                a = 1;
            }
           
            
            switch (a)
            {
                case 1:
                    BeginSalesShare = dataReader.GetFloat(3);
                    Audience = dataReader.GetInt32(4);
                    Screen = dataReader.GetInt32(5);
                    break;
                case 2:
                    BeginSalesShare = dataReader.GetFloat(3);
                    Audience = dataReader.GetInt32(4);
                    Screen = dataReader.GetInt32(5);
                    break;
                case 3:
                    BeginSalesShare = dataReader.GetFloat(3);
                    Audience = dataReader.GetInt32(4);
                    Screen = dataReader.GetInt32(5);
                    break;
                case 4:
                    BeginSalesShare = dataReader.GetFloat(3);
                    Audience = dataReader.GetInt32(4);
                    Screen = dataReader.GetInt32(5);
                    break;
                default:
                    break;
            }
            Debug.Log(dataReader.GetFloat(3)+""+dataReader.GetInt32(4)+""+dataReader.GetInt32(5));
            
        }


        dataReader.Dispose();
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConnection.Close();
        dbConnection = null;
    }
    #endregion
    public void DataBaseThisRead(string query)
    {
        IDbConnection dbConnection = new SqliteConnection(GetDBFilePath());
        dbConnection.Open();
        IDbCommand dbCommand = dbConnection.CreateCommand();
        dbCommand.CommandText = query;
        IDataReader dataReader = dbCommand.ExecuteReader();
        while (dataReader.Read())
        {
            Debug.Log(dataReader.GetInt32(0) + "," + dataReader.GetString(1) + "," + dataReader.GetString(2) + ","
                + dataReader.GetFloat(3) + "," + dataReader.GetInt32(4) + "," + dataReader.GetInt32(5));

            if (dataReader.GetString(1) == "소울")
            {
                a = 1;
            }
            else if (dataReader.GetString(1) == "극장판 귀멸의 칼날: 무한열차편")
            {
                a = 2;
            }
            else if (dataReader.GetString(1) == "세자매")
            {
                a = 3;
            }
            else if (dataReader.GetString(1) == "명탐정 코난: 진홍의 수학여행")
            {
                a = 4;
            }

            switch (a)
            {
                case 1:
                    ThisSalesShare = dataReader.GetFloat(3);
                    Audience = dataReader.GetInt32(4);
                    Screen = dataReader.GetInt32(5);
                    break;
                case 2:
                    ThisSalesShare = dataReader.GetFloat(3);
                    Audience = dataReader.GetInt32(4);
                    Screen = dataReader.GetInt32(5);
                    break;
                case 3:
                    ThisSalesShare = dataReader.GetFloat(3);
                    Audience = dataReader.GetInt32(4);
                    Screen = dataReader.GetInt32(5);
                    break;
                case 4:
                    ThisSalesShare = dataReader.GetFloat(3);
                    Audience = dataReader.GetInt32(4);
                    Screen = dataReader.GetInt32(5);
                    break;
                default:
                    break;
            }
            Debug.Log(dataReader.GetFloat(3) + "" + dataReader.GetInt32(4) + "" + dataReader.GetInt32(5));

        }


        dataReader.Dispose();
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConnection.Close();
        dbConnection = null;
    }
}