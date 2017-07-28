using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class random : MonoBehaviour {
    
    public float time = 2f;
    void Start()
    {
        
        StartCoroutine(randomShow());
    }

    IEnumerator randomShow()
    {
        while (true)
        {  
                   

            gameObject.GetComponent<tap>().istapped = false;
            Vector2 position;
            int RandomNumbery = Random.Range(-4, 3);
            int RandomNumberx = Random.Range(-1, 2);
            position = new Vector2(RandomNumberx, RandomNumbery);
            transform.position = position;

            yield return new WaitForSeconds(score.speed*time);
          
           gameObject.GetComponent<CircleCollider2D>().enabled = true;

           if (gameObject.GetComponent<Renderer>().enabled == true && !GameObject.Find("free").GetComponent<ontuch>().free)
           {
                
                GameObject.Find("greenbar").GetComponent<Image>().fillAmount -= 0.03f;
            }
           
            
            gameObject.GetComponent<Renderer>().enabled = true;
           
        }
    }
}
