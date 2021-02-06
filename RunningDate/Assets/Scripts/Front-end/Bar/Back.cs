using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back : MonoBehaviour
{
    private Manager manager;
    private bool isone;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        if(manager.GetSceneIndex()==1)
        {
            isone = true;
        }
        else
        {
            isone = false;
        }    
    }

    public void click()
    {
        if(isone)
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(manager.GetSceneIndex()-1);
        }
    }
}
