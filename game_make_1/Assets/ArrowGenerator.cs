using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

    public GameObject gArrowPrefab = null;      //화살 prefab을 넣을 빈오브젝트 상자 선언

    GameObject gArrowInstance = null;           //화살 인스턴스 저장 변수

    float fArrowCreateSpan = 0.5f;              //화살 생성 변수 : 화살을 1초마다 생성 변수
    float fDeltaTime = 0.0f;                    //앞 프레임과 현재 프레임 사이의 시간 차이를 저장하는 변수

    int nArrowPositionRange = 0;                //화살의 x 좌표 Range 저장 변수

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fDeltaTime += Time.deltaTime;
        if(fDeltaTime > fArrowCreateSpan)
        {
            fDeltaTime = 0.0f;

            gArrowInstance = Instantiate(gArrowPrefab);

            nArrowPositionRange = Random.Range(-6, 7);      //사용자가 제공한 최소와 최대 사이의 임의의 숫자 제공

            gArrowInstance.transform.position = new Vector3(nArrowPositionRange, 7, 0);
        }
    }
}
