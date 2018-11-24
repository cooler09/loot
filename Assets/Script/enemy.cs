using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public int Health;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Health <= 0)
        {
            Destroy(gameObject);
        }
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("enter");
        if (col.gameObject.name == "missle")
        {
            Destroy(col.gameObject);
            Health -= 10;
        }
    }
}
