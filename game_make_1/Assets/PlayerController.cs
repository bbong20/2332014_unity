using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //�÷��̾ �̵��� ����â�� ����� �ʵ��� Vector �ִ� �ּ� �� ���� ����
    float fMaxPositionX = 8.0f;
    float fMinPositionX = -8.0f;

    //�÷��̾ �̵��� �� �ִ� X��ǥ ���� ����
    float fPositionX = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //���� ȭ��ǥ ������ ��
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }

        //������ ȭ��ǥ�� ������ ��
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }

        /*
         * Mathf.Clamp(value,min,max) �޼���
         * Ư�� ���� ��� ������ ���ѽ�Ű���� �� �� ����ϴ� �޼���
         * value���� ���� : min<=value<=max
         * �ּ�/�ִ밪�� �����Ͽ� ������ ���� �̿ܿ� ���� ���� �ʵ��� �� �� ���
         * �÷��̾ ������ �� �ִ� �ּ�(fMinPositionX/�ִ�(fMaxPositionX) �������� �����Ͽ� �� ������ ����� �ʵ����Ѵ�.
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
