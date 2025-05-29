using UnityEngine;

public class unityfiedMove : MonoBehaviour
{
    public enum MoveType   
    {
        Translate, Rigidbbody, CC
    }
    [Header("�̵� ��� ����")]
    public MoveType movetype = MoveType.Translate;
    public float moveSpeed = 1.0f;

    public Rigidbody rb;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 input = new Vector3 (h, 0,v);
        switch (movetype)
        {
            case MoveType.Translate:
                transform.Translate(input * moveSpeed * Time.deltaTime); //���� ������ ����
                break;
            case MoveType.Rigidbbody:
                
                //�̵��� �� 
                break;
            case MoveType.CC:
                break;
        }
    }
    private void FixedUpdate()
    {
        if(movetype== MoveType.Rigidbbody)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 input = new Vector3(h, 0, v);
            rb.linearVelocity = input * moveSpeed + new Vector3(0,rb.linearVelocity.y,0);
        }
    }
}
