using UnityEngine;
using System.Collections;

public class Power : MonoBehaviour {
    public bool power;
    public bool power2;
    public float timer = 5f;

    void OnTriggerEnter2D(Collider2D co)
    {
        if(co.name == "pacman")
        {
            power = true;
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
        if (co.name == "pacman2_0")
        {
            power2 = true;
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
        }

    }
    void Update()
    {
        var randomint = Random.Range(0, 5);
        if (power == true || power2 == true)
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
            {
                power = false;
                power2 = false;
                switch (randomint)
                {
                    case 0:
                        GameObject.Find("Diamond").GetComponent<Transform>().position = new Vector3(10, -12, 0);
                        break;
                    case 1:
                        GameObject.Find("Diamond").GetComponent<Transform>().position = new Vector3(27, -15, 0);
                        break;
                    case 2:
                        GameObject.Find("Diamond").GetComponent<Transform>().position = new Vector3(4, -18, 0);
                        break;
                    case 3:
                        GameObject.Find("Diamond").GetComponent<Transform>().position = new Vector3(14.5f, -21, 0);
                        break;
                    case 4:
                        GameObject.Find("Diamond").GetComponent<Transform>().position = new Vector3(10, -15, 0);
                        break;
                }
                gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.GetComponent<Collider2D>().enabled = true;
                timer = 5f;
            }
        }
        
    }
	
	
	
}
