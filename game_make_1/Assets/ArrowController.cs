using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject gplayer = null;

    Vector2 vArrowCirclePoint = Vector2.zero;   //화살 중심
    Vector2 vPlayerCirclePoint = Vector2.zero;  //플레이어 중심
    Vector2 vArrowPlayerDir = Vector2.zero;     //화살 플레이어 중심 벡터

    float fArrowRadius = 0.5f;      //화살 반지름
    float fPlayerRadius = 1f;       //플레이어 반지름
    float fArrowPlayerDistance = 0; //화살 중심 플레이어 중심 거리

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gplayer = GameObject.Find("player_0");
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하시킨다.
        transform.Translate(0, -0.1f, 0);

        //화면 밖으로 나오면 오브젝트를 소멸시킨다.
        if(transform.position.y<-5.0f)
        {
            Destroy(gameObject);
        }

        //충돌 판정
        vArrowCirclePoint = transform.position;
        vPlayerCirclePoint = gplayer.transform.position;
        vArrowPlayerDir = vArrowCirclePoint - vPlayerCirclePoint;

        fArrowPlayerDistance = vArrowPlayerDir.magnitude;

        if (fArrowPlayerDistance < fArrowRadius + fPlayerRadius)
        {
            /*
             *플레이어가 화살에 맞으면 화살 컨트롤러에서 감독 스크립트(GameDirector)의 f_DecreaseHp() 메서드를 호출
             *즉, ArrowController에서 GameDirector 오브젝트에 있는 f_DecreaseHp()메서드를 호출하기 때문에
             *Find 메서드를 찾아서 GameDirector 오브젝트를 찾는다.
             */


            GameObject gDirector = GameObject.Find("GameDirector");

            gDirector.GetComponent<GameDirector>().f_DecreaseHp();
            
            //충돌시 화살 제거
            Destroy(gameObject);
        }
    }
}