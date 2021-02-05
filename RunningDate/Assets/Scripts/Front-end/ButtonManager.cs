using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    #region 버튼 클릭 오브젝트
    private GameObject button;
    #endregion
    private Manager manager;
    private Calculate calculate;

    private void Start()
    {
        //Reset
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        calculate = GameObject.Find("Manager").GetComponent<Calculate>();
    }

    #region 버튼 클릭
    public void ButtonInput()
    {
        string name = EventSystem.current.currentSelectedGameObject.transform.parent.name;
        button = EventSystem.current.currentSelectedGameObject.transform.gameObject;
        FindButtonNameFunc(name);
    }
    #endregion

    #region 버튼 이름에 따른 함수 실행
    private void FindButtonNameFunc(string name)
    {
        switch (name)
        {
            case "MovieImage":
                //클릭 버튼의 자식의 이름은 영화 이름
                calculate.SelectMovie(button.name);
                manager.SceneLoad(2);
                break;
            case "Region":
                //클릭 버튼의 자식의 이름은 지역 이름 토글방식으로 할 경우 교체 가능
                calculate.SelectRegion(button.transform.GetChild(0).name);
                break;
            default:
                break;
        }
    }
    #endregion
}
