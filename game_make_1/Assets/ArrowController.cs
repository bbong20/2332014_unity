using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject gplayer = null;

    Vector2 vArrowCirclePoint = Vector2.zero;   //ȭ�� �߽�
    Vector2 vPlayerCirclePoint = Vector2.zero;  //�÷��̾� �߽�
    Vector2 vArrowPlayerDir = Vector2.zero;     //ȭ�� �÷��̾� �߽� ����

    float fArrowRadius = 0.5f;      //ȭ�� ������
    float fPlayerRadius = 1f;       //�÷��̾� ������
    float fArrowPlayerDistance = 0; //ȭ�� �߽� �÷��̾� �߽� �Ÿ�

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gplayer = GameObject.Find("player_0");
    }

    // Update is called once per frame
    void Update()
    {
        //�����Ӹ��� ������� ���Ͻ�Ų��.
        transform.Translate(0, -0.1f, 0);

        //ȭ�� ������ ������ ������Ʈ�� �Ҹ��Ų��.
        if(transform.position.y<-5.0f)
        {
            Destroy(gameObject);
        }

        //�浹 ����
        vArrowCirclePoint = transform.position;
        vPlayerCirclePoint = gplayer.transform.position;
        vArrowPlayerDir = vArrowCirclePoint - vPlayerCirclePoint;

        fArrowPlayerDistance = vArrowPlayerDir.magnitude;

        if (fArrowPlayerDistance < fArrowRadius + fPlayerRadius)
        {
            /*
             *�÷��̾ ȭ�쿡 ������ ȭ�� ��Ʈ�ѷ����� ���� ��ũ��Ʈ(GameDirector)�� f_DecreaseHp() �޼��带 ȣ��
             *��, ArrowController���� GameDirector ������Ʈ�� �ִ� f_DecreaseHp()�޼��带 ȣ���ϱ� ������
             *Find �޼��带 ã�Ƽ� GameDirector ������Ʈ�� ã�´�.
             */


            GameObject gDirector = GameObject.Find("GameDirector");

            gDirector.GetComponent<GameDirector>().f_DecreaseHp();
            
            //�浹�� ȭ�� ����
            Destroy(gameObject);
        }
    }
}