using UnityEngine;
using System.Collections;

public class Rocktopus : MonoBehaviour {

    public Transform startPoint;

    public int health = 5;
    public float moveVelocityH;
    public float torqueForce;
    public GameObject octoParticle;
    public static int amountOfRocktopus;

    public GameObject projectile;
    public Transform tenPoint;

	// Use this for initialization
	void Start ()
    {
        amountOfRocktopus = 0;
        InvokeRepeating("LaunchProjectile", 20.0f, 0.6f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (health <= 0)
        {
            amountOfRocktopus = amountOfRocktopus + 1;
            
            Instantiate(octoParticle, transform.position, Quaternion.identity);
            transform.position = startPoint.position;
            torqueForce = 10;
            health = 5;

        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().AddTorque(torqueForce);
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityH, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Moon")
        {

            health = health - 1;

        }

        

        if (other.collider.tag == "ResetTag")
        {
            transform.position = startPoint.position;
        }



    }

    void LaunchProjectile()
    {

        Instantiate(projectile, tenPoint.position, Quaternion.identity);

        
    }

}
