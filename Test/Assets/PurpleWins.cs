using UnityEngine;
using System.Collections;

public class PurpleWins : MonoBehaviour{
    Power power2;
    Power power;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman2_0" && GameObject.Find("Diamond").GetComponent<Power>().power2 == true)
            Destroy(gameObject);
        }
    void Update()
    {
        if (GameObject.Find("Diamond").GetComponent<Power>().power == true)
        {
            TrailRenderer tr = gameObject.AddComponent<TrailRenderer>() as TrailRenderer;
            gameObject.GetComponent<TrailRenderer>().time = 1.2f;
            gameObject.GetComponent<TrailRenderer>().startWidth = .8f;
            gameObject.GetComponent<TrailRenderer>().endWidth = .1f;
            Destroy(gameObject.GetComponent<TrailRenderer>(), 5);
        }

    }
}
