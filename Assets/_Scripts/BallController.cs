using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallController : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float h= Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

  
    }


        Vector3 movement = new Vector3(h, 0, v);
        rbody.AddForce(movement * speed);
    }
}
