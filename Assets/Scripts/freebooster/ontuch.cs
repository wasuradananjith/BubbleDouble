using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ontuch : MonoBehaviour {
    float health;
    public bool free;
    public Text disfree;
    public Button freebutton;
    public Button dublebutton;
    string freecountKey = "freeboosters";
    public AudioSource sound;
	// Use this for initialization
	void Start () {
        score.freecount = PlayerPrefs.GetInt(freecountKey, 0);

	}
	
	// Update is called once per frame
	void Update () {
        if (score.freecount == 0)
        {
            freebutton.interactable = false;
            
        }

	}
   public void OnMouseDown()
    {
        if (score.freecount > 0)
        {
            sound.Play();
            freebutton.interactable = false;
            dublebutton.interactable = false;
            score.freecount -= 1;
            free = true;
            disfree.text = score.freecount.ToString();
            PlayerPrefs.SetInt(freecountKey, score.freecount);
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
        free = false;
        freebutton.interactable = true;
        dublebutton.interactable = true;
        GameObject.Find("boosterbar").GetComponent<Image>().fillAmount = 1f;
       
    }
}
