using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    private List<bool> goodQuad  = new List<bool>();
    private int score;

    private List<bool> badQuad = new List<bool>();
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

    public int AddGoodQuad()
    {
        goodQuad.Add(false);;
        return goodQuad.Count;
    }
    public int AddBadQuad()
    {
        badQuad.Add(false);
        return badQuad.Count;
    }

    public void QuadCollided(bool isGood, int id)
    {
        if (isGood)
        {
            goodQuad[id - 1] = true;
        }
        else
        {
            badQuad[id - 1] = true;
        }
    }

}
