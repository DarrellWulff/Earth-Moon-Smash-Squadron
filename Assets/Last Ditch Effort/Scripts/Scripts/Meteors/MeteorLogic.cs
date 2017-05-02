using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorLogic : MonoBehaviour {


    public Transform startPoint;
    public float moveVelocityH;
    public float moveVelocityY;
    public bool isSmashed = false;
    public GameObject meteorParticle;

    public static int amountOfMeteor;



    

    // Use this for initialization
    void Start ()
    {
        amountOfMeteor = 0;

    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    private void FixedUpdate()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityH, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if ((other.gameObject.tag == "Moon" & isSmashed == true) || (other.gameObject.tag == "Projectile" & isSmashed == true))
        {
            Instantiate(meteorParticle, transform.position, Quaternion.identity);
            transform.position = startPoint.position;
            isSmashed = false;
            return;

        } 

        if (other.gameObject.tag == "Moon" & isSmashed == false || other.gameObject.tag == "Projectile" & isSmashed == false)
        {

           amountOfMeteor = amountOfMeteor + 1;
           isSmashed = true;
           return;

        }

        if (other.collider.tag == "ResetTag")
        {
            transform.position = startPoint.position;
        }

        

    }
}
