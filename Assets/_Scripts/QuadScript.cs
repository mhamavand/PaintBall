using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class QuadScript : MonoBehaviour
{
    //public bool isGood;
   // private int id;
    // Start is called before the first frame update
    private Material rend;
    public int count;
    
    void OnTriggerExit(Collider other)
    {
        transform.rotation=Quaternion.AngleAxis(180,Vector3.right);
        rend.color=Color.yellow;
        count += 1;
    }
    void Start()
    {
       // GameManager.instance.AddGoodQuad(this);
       rend = GetComponent<Renderer>().material;
    }

  /*  private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.QuadCollided(this);
        this.Colorize();
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
