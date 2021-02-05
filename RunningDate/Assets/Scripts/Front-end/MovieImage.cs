using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovieImage : MonoBehaviour
{
    private navermovies nm;
    private Movie m;
    public Text Text;
    public Text DirName;

    private void Start()
    {
        nm = GameObject.Find("Main Camera").GetComponent<navermovies>();
        m=nm.Print(this.gameObject.transform.GetChild(0).name);
        Text.text = "";
        Text.text += m.Name;
        Text.text += "\n";
        Text.text += m.DirectorName;
        Text.text += "\n";
        Text.text += m.UserRating;
        
        DirName.text = "";
        DirName.text = m.EName;
    }
}
