using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform target;
    public Transform parent;
    public float movSpeed;
    void Start()
    {
        
    }

    void Update()
    {
     
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.GetComponent<Collider2D>().tag == "Player"){
            parent.position = Vector3.MoveTowards(transform.position, target.position, movSpeed * Time.deltaTime);     
        }
    }
}
