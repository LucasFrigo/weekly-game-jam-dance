using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform objToFollow;
    public Vector3 offset;


    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(objToFollow.position.x + offset.x, objToFollow.position.y + offset.y, offset.z);   
    }
}
