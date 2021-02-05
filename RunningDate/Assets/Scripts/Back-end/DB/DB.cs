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
    Array[] array = new Array[17];


    void Start()
    {
        calculate = this.gameObject.GetComponent<Calculate>();


        DBConnectionCheck();
        DataBaseRead("Select * From ");

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        

        calculate.MovieName = MovieName;
        calculate.setBeginSalesShare(BeginSalesShare);
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
    public void DataBaseRead(string query)
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
        }

        dataReader.Dispose();
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConnection.Close();
        dbConnection = null;
    }
    #endregion
    #region DB검색
    public void DBSearch(string query)
    {
        IDbConnection dbConnection = new SqliteConnection(GetDBFilePath());
        dbConnection.Open();
        IDbCommand dbCommand = dbConnection.CreateCommand();
        dbCommand.CommandText = query;
        dbCommand.ExecuteReader();

        dbCommand.Dispose();
        dbCommand = null;
        dbConnection.Close();
        dbConnection = null;
    }
    #endregion

}