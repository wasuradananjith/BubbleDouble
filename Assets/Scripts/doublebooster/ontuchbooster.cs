using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ontuchbooster : MonoBehaviour {
    public  bool doublescore=false;
     public Button freebutton;
    public Button dublebutton;
    public Text disdouble;
    string dobleKey = "doubleboosters";
    public int doublecount;
    public AudioSource sound;
	// Use this for initialization
    void Start()
    {
        doublecount = PlayerPrefs.GetInt(dobleKey, 0);
        disdouble.text = doublecount.ToString();
    }
    void Update()
    {   if(doublecount==0)
        dublebutton.interactable = false;
    }

	public void onclick(){
        if (doublecount > 0)
        {
            sound.Play();
            freebutton.interactable = false;
            dublebutton.interactable = false;
            doublecount -= 1;
            doublescore = true;
            disdouble.text = doublecount.ToString();
            PlayerPrefs.SetInt(dobleKey, doublecount);
            StartCoroutine(randomShow());
            
        }
    }
       IEnumerator randomShow()
    {
        while (GameObject.Find("boosterbar").GetComponent<Image>().fillAmount != 0.0f)
        {
            
            GameObject.Find("boosterbar").GetComponent<Image>().fillAmount -= 0.02f;
            yield return new WaitForSeconds(.20f);
        }
        doublescore = false;
        freebutton.interactable = true;
        dublebutton.interactable = true;
        GameObject.Find("boosterbar").GetComponent<Image>().fillAmount = 1f;
       
    }

}
