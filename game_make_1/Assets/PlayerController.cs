using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //플레이어가 이동시 게임창을 벗어나지 않도록 Vector 최대 최소 값 설정 변수
    float fMaxPositionX = 8.0f;
    float fMinPositionX = -8.0f;

    //플레이어가 이동할 수 있는 X좌표 저장 변수
    float fPositionX = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //왼쪽 화살표 눌렀을 때
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }

        //오른쪽 화살표가 눌렸을 때
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }

        /*
         * Mathf.Clamp(value,min,max) 메서드
         * 특정 값을 어떠한 범위에 제한시키고자 할 때 사용하는 메서드
         * value값의 범위 : min<=value<=max
         * 최소/최대값을 설정하여 지정한 범위 이외에 값이 되지 않도록 할 때 사용
         * 플레이어가 움직일 수 있는 최소(fMinPositionX/최대(fMaxPositionX) 범위값을 설정하여 그 범위를 벗어나지 않도록한다.
         */

        fPositionX = Mathf.Clamp(transform.position.x, fMinPositionX, fMaxPositionX);
        transform.position = new Vector3(fPositionX, transform.position.y, transform.position.z);
    }

    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    }
}
