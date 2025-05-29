using UnityEngine;

public class playeranimationncontroller : MonoBehaviour
{
    public Animator playeranim;
    private void Awake()
    {
        playeranim= GetComponentInChildren<Animator>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void UpdateMoveAnim(float _speed)
    {
        playeranim.SetFloat("Move",_speed);
    }
}
