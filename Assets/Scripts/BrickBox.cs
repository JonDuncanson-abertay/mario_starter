using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBox : MonoBehaviour {


	// Use this for initialization
	void Start () {
        gameObject.SetActive(true);
	}

    /*void OnCollisionEnter(Collision collision)
    {
        //if (gameObject.activeSelf)
        Debug.Log("oh boi");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("oh boi");
        }
    }*/
	
	// Update is called once per frame
	void Update () {
    }
}
