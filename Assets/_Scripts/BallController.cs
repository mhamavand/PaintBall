using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody=this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h=Input.GetAxis("Horizontal") ;
        float V=Input.GetAxis("Vertical") ;
        
        Vector3 movement=new Vector3(h,0,V);
        rbody.AddForce(movement*speed);
    }

}
