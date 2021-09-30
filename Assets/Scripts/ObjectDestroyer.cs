using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.tag == "wood" || collision.gameObject.tag == "perfect" || collision.gameObject.tag == "good" || collision.gameObject.tag == "bad")
        {
            Destroy(collision.gameObject);
        }
    }



}
