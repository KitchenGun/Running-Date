using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    private static Manager instance = null;


    void Awake()
    {
        #region singletonObject
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        #endregion
    }


    #region Scene움직임
    public void SceneLoad(int idx)
    {
        SceneManager.LoadScene(idx);
    }
    #endregion

}
