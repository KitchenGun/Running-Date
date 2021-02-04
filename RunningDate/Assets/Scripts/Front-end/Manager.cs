using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    private static Manager instance = null;
    // Start is called before the first frame update
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    #region go MovieSelect
    public void MovieSelect ()
    {
        SceneManager.LoadScene(1);
    }
    #endregion

}
