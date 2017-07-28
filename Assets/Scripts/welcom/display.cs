using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class display : MonoBehaviour {
    int count=0;
	// Use this for initialization
	void Start () {
        StartCoroutine(randomShow());
	}

    IEnumerator randomShow()
    {
        while (count==0)
        {
            yield return new WaitForSeconds(2.5f);
            count++;
        }
        SceneManager.LoadScene("Homescreen");
    }
	
}
