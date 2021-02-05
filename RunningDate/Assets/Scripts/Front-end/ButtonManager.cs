using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    #region 버튼 클릭 오브젝트
    private GameObject button;
    #endregion

    private Calculate calculate;

    private void Start()
    {
        //Reset
        calculate = this.gameObject.GetComponent<Calculate>();
    }

    #region 버튼 클릭
    public void ButtonInput()
    {
        button=EventSystem.current.currentSelectedGameObject;
    }
    #endregion

    #region 버튼 이름에 따른 함수 실행
    private void FindButtonNameFunc(string name)
    {
        switch (button.name)
        {
            case "MovieImage":
                //클릭 버튼의 자식의 이름은 영화 이름
                calculate.SelectMovie(button.transform.GetChild(0).name);
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
