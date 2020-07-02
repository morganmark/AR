using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    Rigidbody rigid;
    public float force = 5;

    void Start()
    {
        rigid = transform.GetComponent<Rigidbody>();
    }


    void Update()
    {
        rigid.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * force);
    }
}

