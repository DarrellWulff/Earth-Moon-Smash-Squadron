using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPosition : MonoBehaviour {

    public GameObject meteor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {

        transform.position = meteor.transform.position;
        
    }
}
