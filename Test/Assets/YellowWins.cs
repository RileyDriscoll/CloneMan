using UnityEngine;
using System.Collections;

public class YellowWins : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman" && GameObject.Find("Diamond").GetComponent<Power>().power == true)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(GameObject.Find("Diamond").GetComponent<Power>().power2 == true)
        {
            TrailRenderer tr = gameObject.AddComponent<TrailRenderer>() as TrailRenderer;
            gameObject.GetComponent<TrailRenderer>().time = 1.2f;
            gameObject.GetComponent<TrailRenderer>().startWidth = .8f;
            gameObject.GetComponent<TrailRenderer>().endWidth = .1f;
            Destroy(gameObject.GetComponent<TrailRenderer>(), 5);
        }
               
    }
}
