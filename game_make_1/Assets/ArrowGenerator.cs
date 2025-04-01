using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

    public GameObject gArrowPrefab = null;      //ȭ�� prefab�� ���� �������Ʈ ���� ����

    GameObject gArrowInstance = null;           //ȭ�� �ν��Ͻ� ���� ����

    float fArrowCreateSpan = 0.5f;              //ȭ�� ���� ���� : ȭ���� 1�ʸ��� ���� ����
    float fDeltaTime = 0.0f;                    //�� �����Ӱ� ���� ������ ������ �ð� ���̸� �����ϴ� ����

    int nArrowPositionRange = 0;                //ȭ���� x ��ǥ Range ���� ����

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

            nArrowPositionRange = Random.Range(-6, 7);      //����ڰ� ������ �ּҿ� �ִ� ������ ������ ���� ����

            gArrowInstance.transform.position = new Vector3(nArrowPositionRange, 7, 0);
        }
    }
}
