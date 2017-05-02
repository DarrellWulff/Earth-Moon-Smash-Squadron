using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor2Logic : MonoBehaviour {

    public MeteorLogic meteor1;
    
    public float moveVelocityH;
    public bool isSmashed2 = false;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void FixedUpdate()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Moon" & isSmashed2 == false)
        {


            gameObject.SetActive(false);
            isSmashed2 = true;
            transform.position = transform.parent.position;





        }
    }
}
