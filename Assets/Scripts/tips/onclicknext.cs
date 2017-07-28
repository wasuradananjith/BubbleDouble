using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onclicknext : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    public void onclicknextbutton()
    {
        SceneManager.LoadScene("tips2");
    }
    public void onclickhome()
    {
        SceneManager.LoadScene("Homescreen");
    }

}
