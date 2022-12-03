using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    // Start is called before the first frame update



    void Start()
    {
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
        Debug.Log("you have collected: " + gameObject.name);

        Destroy(gameObject);
    }   

        
    }
}
