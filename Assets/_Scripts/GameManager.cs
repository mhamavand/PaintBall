using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int count = 0;
   private void Update()
    {
        if ((count = 10) != 0)
        {
            Debug.Log("player Won!"); 
        }
      else
      {
          Debug.Log("Player lost!");
      }
    }

    /*public static GameManager instance = null;

    private bool[] goodQuad;
    private int Score;

    private bool[] badQuad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void QuadCollided(QuadScript quadScript)
    {
        if (quadScript.isGood == true)
        {
            Score += 1;
        }
        else if (quadScript.isGood == false)
        {
            Score -= 1;
        }
    }*/

}
