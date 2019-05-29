using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GoodQuadScript : MonoBehaviour
{
    private int id;

    private void OnTriggerEnter(Collider other)
    {
        // in layer settings quads can only colide with players
        GameManager.instance.QuadCollided(true, id);
        Debug.Log("GoodQuadCollided");
    }

    void Start()
    {
        id = GameManager.instance.AddGoodQuad();
        Debug.Log("Good quad created with id " + id);
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
