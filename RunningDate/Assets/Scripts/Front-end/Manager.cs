using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private static Manager instance = null;

    #region fadeinout효과 변수
    private GameObject Panel;
    Color blackColor = Color.black;
    Color offColor = Color.clear;
    Color startColor = Color.black;
    Color targetColor = Color.black;
    private bool isOnTransition = false;
    float fadeTime = 0.5f;
    float delay = 0f;
    #endregion
    #region 씬이 로드될때 마다 호출하는 이벤트 함수
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        
    }
    #endregion

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

    private void Start()
    {
        Panel = GameObject.Find("Main Camera").transform.GetChild(0).GetChild(GameObject.Find("Main Camera").transform.childCount).gameObject;
        BlackIn(3f);

        if(GetSceneIndex()==0)
        {
            Invoke("Sceneload1", 4f);
        }
    }

    #region Fade
    public void BlackIn(float a_fadeTime = 0.5f, float a_delay = 0f)
    {
        fadeTime = a_fadeTime;
        delay = a_delay;

        Panel.GetComponent<Image>().enabled = true;
        Panel.GetComponent<Image>().color = blackColor;
        startColor = blackColor;
        targetColor = offColor;
        Panel.GetComponent<Image>().raycastTarget = false;

        if (isOnTransition)
            StopCoroutine("UpdateColorCoroutine");

        StartCoroutine("UpdateColorCoroutine");
        OnDisable();
    }

    public void BlackOut(float a_fadeTime = 0.5f, float a_delay = 0f)
    {
        fadeTime = a_fadeTime;
        delay = a_delay;

        Panel.GetComponent<Image>().enabled = true;
        startColor = offColor;
        targetColor = blackColor;
        Panel.GetComponent<Image>().raycastTarget = true;

        if (isOnTransition)
            StopCoroutine("UpdateColorCoroutine");

        StartCoroutine("UpdateColorCoroutine");
    }

    IEnumerator UpdateColorCoroutine()
    {
        isOnTransition = true;

        if (delay != 0)
            yield return new WaitForSeconds(delay);

        float t = 0;
        while (t < 1)
        {
            Panel.GetComponent<Image>().color = Color.Lerp(startColor, targetColor, t);
            t += Time.deltaTime / fadeTime;
            yield return new WaitForEndOfFrame();
        }

        if (targetColor == Color.clear) // 시간을 지났을 경우! 즉 트랜지션 끝남
            Panel.GetComponent<Image>().enabled = false;

        isOnTransition = false;
    }
    #endregion

    #region 현재씬 수치값 불러오기
    public int GetSceneIndex()
    {
        int idx;
        idx = SceneManager.GetActiveScene().buildIndex;

        return idx;
    }
    #endregion

    #region Scene움직임
    private void Sceneload1()
    {
        SceneManager.LoadScene(1);
    }
    public void SceneLoad(int idx)
    {
        SceneManager.LoadScene(idx);
    }
    #endregion

}
