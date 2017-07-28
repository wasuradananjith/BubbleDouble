using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour {
    public float time = .1f;
    public float time2 = 2f;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        StartCoroutine(randomShow());
	}

    IEnumerator randomShow()
    {
        while (true)
        {

           gameObject.GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(score.speed * time);
            Vector2 position;
            int RandomNumbery = Random.Range(-4, 3);
            int RandomNumberx = Random.Range(-1, 2);
            position = new Vector2(RandomNumberx, RandomNumbery);
            transform.position = position;
            gameObject.GetComponent<Renderer>().enabled = true;
            if (GameObject.Find("greenbar").GetComponent<Image>().fillAmount == 0.0f)
            {
                
                gameObject.SetActive(false);
               

            }

            yield return new WaitForSeconds(score.speed * time2);
        }
    }
}
