using UnityEngine;
using System.Collections;

public class PowerBit : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D co)
    {
        if(co.name == "pacman" || co.name == "pacman2_0")
        {
            Destroy(gameObject);
        }
    }
}
