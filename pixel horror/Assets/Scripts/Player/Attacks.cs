using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    public Collider2D batColliderRight;
    public Collider2D batColliderLeft;

    Vector2 rightAttackOffset;

    


    private void Start()
    {
        rightAttackOffset = transform.position;
    }
   
    public void AttackRight()
    {
        batColliderLeft.enabled = true;
    }
    public void AttackLeft()
    {
        batColliderRight.enabled = true;
    }
    public void StopAttack()
    {
        batColliderRight.enabled = false;
        batColliderLeft.enabled = false;
    }
}
