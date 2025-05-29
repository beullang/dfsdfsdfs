using Unity.Mathematics;
using UnityEngine;

public class playerRotatefollower : MonoBehaviour
{
    public Transform followTarget;
    public float rotateSpeed = 10f;

    private void Update()
    {
        Vector3 targetForward=followTarget.forward;
        targetForward.y = 0;
        if (targetForward.sqrMagnitude > 0.01f)
        {
            Quaternion targetRotation=Quaternion.LookRotation(targetForward);
            transform.rotation=Quaternion.Slerp(transform.rotation,targetRotation, rotateSpeed);
        }
    }
}
