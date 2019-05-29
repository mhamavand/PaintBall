using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadQuadScript : MonoBehaviour
{
    private int id;

    private void OnTriggerEnter(Collider other)
    {
        // in layer settings quads can only colide with players
        GameManager.instance.QuadCollided(false, id);
        Debug.Log("BadQuadCollided id : " + id);
    }

    void Start()
    {
        id = GameManager.instance.AddBadQuad();
        Debug.Log("Bad quad created with id " + id);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
