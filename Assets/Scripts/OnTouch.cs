using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTouch : MonoBehaviour {
    void Start()
    {
        Time.timeScale = 1;
    }


    public AudioSource sound;
    int mul=1;
    void OnMouseDown()
    {
        if (GameObject.Find("doublebooster").GetComponent<ontuchbooster>().doublescore)
            mul = 2;
        if(!pauseplay.isPaused){
            score.tscore += 10*mul;
            sound.Play();
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<tap>().istapped = true;
            if (GameObject.Find("greenbubble").GetComponent<tap>().istapped)
            {
                score.tscore += 5*mul;
                GameObject.Find("greenbar").GetComponent<Image>().fillAmount += 0.03f;
            }
            else if (GameObject.Find("redbobble").GetComponent<tap>().istapped)
            {
                if (!GameObject.Find("free").GetComponent<ontuch>().free)
                {
                    score.tscore -= 15;
                    GameObject.Find("greenbar").GetComponent<Image>().fillAmount -= 0.03f;
                }
            }
            gameObject.GetComponent<tap>().istapped = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;//this is to avoid geting the score when bubble is invisible
          

        }
        
    }
}







































//all rights reserved for try catch++ team with D.R.Kodagoda