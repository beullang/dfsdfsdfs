using UnityEditor;
using UnityEngine;

//Input system  ���������� �ڵ�� �Է¤��Ѥ� ������ ���� �޾Ƽ� ���
public class PlayerInputReader : MonoBehaviour
{
    public Vector3 MoveInput { get; private set; } //������Ƽ
    public bool JumpPressed { get; private set; }

    //public bool IsFireing = Input.GetButton("Fire1"); //����Ŭ��
    public float MouseX { get; private set; } //���콺 x��ġ 
    public float MouseY { get; private set; }// y��ġ

    private void Update()
    {
        MoveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        JumpPressed = Input.GetButtonDown("Jump");
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");
    }
}
