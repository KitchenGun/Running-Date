﻿using UnityEngine;
using System;
using System.Data;
using System.IO;
using Mono.Data.SqliteClient;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class DB : MonoBehaviour
{
    void Start()
    {
        DBConnectionCheck();
        DataBaseRead("Select * From DB");
    }


    void Update()
    {
        StartCoroutine(DBCreate());
    }

    #region DB생성
    IEnumerator DBCreate()
    {
        string filepath = string.Empty;
        if(Application.platform == RuntimePlatform.Android)
        {
            filepath = Application.persistentDataPath + "/DB.db";
            if (!File.Exists(filepath))
            {
                UnityWebRequest unityWebRequest = UnityWebRequest.Get("jar:file://" + Application.dataPath + "!/assets/DB.db");
                unityWebRequest.downloadedBytes.ToString();
                yield return unityWebRequest.SendWebRequest().isDone;
                File.WriteAllBytes(filepath, unityWebRequest.downloadHandler.data);
            }
        }
        else
        {
            filepath = Application.dataPath + "/DB.db";
            if (!File.Exists(filepath))
            {
                File.Copy(Application.streamingAssetsPath + "/DB.db", filepath);
            }
        }
        Debug.Log("생성 완료");
    }
    #endregion
    #region DB파일 경로
    public string GetDBFilePath()
    {
        string str = string.Empty;
        if(Application.platform == RuntimePlatform.Android)
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
                + dataReader.GetInt32(3) + "," + dataReader.GetFloat(4) + "," + dataReader.GetString(5) + "," 
                + dataReader.GetFloat(6) + "," + dataReader.GetString(7) + ","+ dataReader.GetInt32(8) + "," 
                + dataReader.GetString(9) + "," + dataReader.GetFloat(10) + "," + dataReader.GetFloat(11) + "," 
                + dataReader.GetInt32(12) + "," + dataReader.GetInt32(13) + "," + dataReader.GetString(14) + "," 
                + dataReader.GetString(15) + "," + dataReader.GetString(16));
        }
        dataReader.Dispose();       
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConnection.Close();   
        dbConnection = null;
    }
    #endregion
    #region
    public void DatabaseInsert(string query)
    {

    }
    #endregion
}



