using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerAimContoller : MonoBehaviour
{
    public float sensyX = 150f; //���콺 �ΰ��� x��
    public float sensyY = 100f; //���콺 �ΰ��� y��
    public float minPitch = -60f;  //�ּ� ����
    public float maxPithc = 70f;
    private float pitch = 0f;

    public PlayerInputReader input; //�Է������� Ŭ����

    private void Update()
    {
        float mouseX = input.MouseX * sensyX * Time.deltaTime;  //
        float mouseY = input.MouseY * sensyY * Time.deltaTime;

        //Y�� �¿� ȸ�� ó��
        transform.Rotate(Vector3.up, mouseX, Space.World); //������ �������� ȸ��

        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, minPitch, maxPithc); //���� ���

        Vector3 currentEuler = transform.localEulerAngles; //
        currentEuler.x = pitch;
        transform.localEulerAngles = currentEuler;
        
    }
}
