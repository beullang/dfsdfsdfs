using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    //�ä��Ĥ��Ӥ��� �Ȥ��Ǥ���
    public Transform target; //���� ���� �ٴϤ� Ÿ�Ԥ�
    public Vector3 offset; //���� Ÿ�Ԥ��������Ǥ��� �����Ť�

    private void LateUpdate()  //�����Ĥ��Ӥ��Ѥ��� ���������� �ʤ��� ��������Ʈ�� ȣ�ߤ� 
    {
        transform.position = target.position + offset; //�� ��ġ= �󤧤������� ��ġ+ �����Ť�
    }
}
