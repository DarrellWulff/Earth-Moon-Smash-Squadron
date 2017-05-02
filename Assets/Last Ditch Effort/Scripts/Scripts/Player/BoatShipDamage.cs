using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatShipDamage : MonoBehaviour {

    public GameObject boatShip;
    public int PlayerHealth;
    

    // Use this for initialization
    void Start ()
    {
        PlayerHealth = 60;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerHealth <= 0)
        {

            gameObject.SetActive(false);
            boatShip.SetActive(false);

        }
        
    }

    private void FixedUpdate()
    {
        transform.position = boatShip.transform.position;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Projectile")
        {


            PlayerHealth -= 1;



        }
    }

}
