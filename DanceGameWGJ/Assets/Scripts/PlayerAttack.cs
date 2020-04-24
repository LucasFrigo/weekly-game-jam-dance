using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private BoxCollider2D hitbox;
    private Animator anim;

    void Start()
    {
        hitbox = GetComponent<BoxCollider2D>();
        anim = gameObject.GetComponentInParent(typeof(Animator)) as Animator;
    }


    void Update()
    {
        anim.SetBool("isAttacking", false);
        hitbox.enabled = false;
        if(Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetBool("isAttacking", true);
            hitbox.enabled = true;
            Debug.Log("Z pressed");
        }

        if(Input.GetKeyDown("left")){
            hitbox.
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy hit");
            Destroy(col.gameObject);
        }
    }
}
