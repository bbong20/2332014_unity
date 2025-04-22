using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using System.Collections;

public class GameDirector : MonoBehaviour
{
    GameObject gHpGauge = null;
    public float fGameTime = 0;
    public Text GameTimeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gHpGauge = GameObject.Find("HpGauge");

    }

    // Update is called once per frame
    void Update()
    {
        if(gHpGauge.GetComponent<Image>().fillAmount ==0)
        {
            Time.timeScale = 0f;
        }

        fGameTime += Time.deltaTime;
        GameTimeText.text = "Time: " + (int)fGameTime;

        
    }

    /*
     * 나중에 화살 컨트롤러에서 HP 게이지 표시를 줄이는 처리를 호출할 것을 고려해
     * HP 게이지의 처리는 public 메서드를 작성
     * 화살과 플레이어가 충돌했을 때 화살 컨트롤러가 f_DecreaseHp()메서드를 호출함
     * 메서드의 기능은 화살과 플레이어가 충돌했을 때 Image오브젝터(hpgauge)의 fillAmount를 줄여
     * HP 게이지를 표시하는 비율을 10%씩 낮춤
    */

    public void f_DecreaseHp()
    {
        /*
         * 유니티 오브젝트는 GameObject라는 빈 상자에 설정 자료(컴포넌트)를 추가해서 기능을 확장함
         * 컴포넌트 접근 방법 : GetComponent<>()
         * GetComponent는 게임 오브젝트에 대해 컴포넌트를 요청하면 해당되는 컴포넌트(기능)을 주는 메서드
        */

        //화살과 플레이어가 충돌했을 때 Image 오브젝xm(HpGauge)의 fillAmount를 줄여
        //HP 게이지를 표시하는 비율을 10%씩 낮춤
        gHpGauge.GetComponent<Image>().fillAmount -= 0.1f; 

        if(gHpGauge.GetComponent<Image>().fillAmount ==0.0f)
        {
            SceneManager.LoadScene("EndScene");
        }
        
    }


}
