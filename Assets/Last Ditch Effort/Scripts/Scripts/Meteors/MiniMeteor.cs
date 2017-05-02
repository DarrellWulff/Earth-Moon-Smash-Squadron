using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMeteor : MonoBehaviour {

    public float moveVelocityH;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityH, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Moon")
        {


            
            gameObject.SetActive(false);



            transform.position = transform.parent.position;






        }
    }
}
