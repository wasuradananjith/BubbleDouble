using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soundonoff : MonoBehaviour {

    public bool flag = true;
    public GameObject obj;
    public Button button;
    public Sprite on;
    public Sprite off;
    
	// Update is called once per frame
	public void onclick(){
        if (flag)
        {   
            obj.SetActive(false);
            flag = false;
            button.image.overrideSprite = off;
        }
        else
        {
            obj.SetActive(true);
            flag = true;
            button.image.overrideSprite = on;
        }
            
	}
}
