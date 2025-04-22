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
     * ���߿� ȭ�� ��Ʈ�ѷ����� HP ������ ǥ�ø� ���̴� ó���� ȣ���� ���� �����
     * HP �������� ó���� public �޼��带 �ۼ�
     * ȭ��� �÷��̾ �浹���� �� ȭ�� ��Ʈ�ѷ��� f_DecreaseHp()�޼��带 ȣ����
     * �޼����� ����� ȭ��� �÷��̾ �浹���� �� Image��������(hpgauge)�� fillAmount�� �ٿ�
     * HP �������� ǥ���ϴ� ������ 10%�� ����
    */

    public void f_DecreaseHp()
    {
        /*
         * ����Ƽ ������Ʈ�� GameObject��� �� ���ڿ� ���� �ڷ�(������Ʈ)�� �߰��ؼ� ����� Ȯ����
         * ������Ʈ ���� ��� : GetComponent<>()
         * GetComponent�� ���� ������Ʈ�� ���� ������Ʈ�� ��û�ϸ� �ش�Ǵ� ������Ʈ(���)�� �ִ� �޼���
        */

        //ȭ��� �÷��̾ �浹���� �� Image ������xm(HpGauge)�� fillAmount�� �ٿ�
        //HP �������� ǥ���ϴ� ������ 10%�� ����
        gHpGauge.GetComponent<Image>().fillAmount -= 0.1f; 

        if(gHpGauge.GetComponent<Image>().fillAmount ==0.0f)
        {
            SceneManager.LoadScene("EndScene");
        }
        
    }


}
