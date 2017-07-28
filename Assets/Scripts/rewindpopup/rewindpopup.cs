using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rewindpopup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(randomShow());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator randomShow()
    {
        while (GameObject.Find("timecircle").GetComponent<Image>().fillAmount != 0.0f)
        {

            GameObject.Find("timecircle").GetComponent<Image>().fillAmount -= 0.003f;
            yield return new WaitForSeconds(.01f);
        }
        SceneManager.LoadScene("Gameover");
      
    }
}
