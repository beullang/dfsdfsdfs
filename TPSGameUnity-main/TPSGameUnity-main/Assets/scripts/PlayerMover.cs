using UnityEngine;

[RequireComponent(typeof(CharacterController))] //
public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float gravity = -9.91f; //�⺻ �߷°�

    private float verticalVelocity; //���� ���� �ӵ�

    private CharacterController cc;
    private PlayerInputReader inputReader;
    public Transform cameraTransform;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();
        inputReader = GetComponent<PlayerInputReader>();
    }

    private void Update()
    {
        Vector2 move = inputReader.MoveInput;
        Vector3 moveDirection = cameraTransform.right * move.x + cameraTransform.forward * move.y;
        moveDirection.y = 0f;

        if (cc.isGrounded)
            verticalVelocity = -1f;
        else
            verticalVelocity += gravity * Time.deltaTime;

        moveDirection.y = verticalVelocity;
        cc.Move(moveDirection*moveSpeed*Time.deltaTime);
    }
}
