using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour {
    //old Code, changed plans.
    //Player movement Variables
    public float moveSpeed;
    private float moveVelocityH;
    private float moveVelocityV;
    private float newPositionY;
    private Vector3 moveDirection;

    

    //Animate based on input/Movement
    private Animator anim;


    //Mouse Speed
    private float mouseSpeedV;
    private float mouseSpeedH;

    // Use this for initialization
    void Start ()
    {
        
        anim = GetComponent<Animator>();


    }
	
	// Update is called once per frame
	void Update ()
    {

        
        





    }

    private void FixedUpdate()
    {
        //Tests
        //newPositionY = Mathf.SmoothDamp(transform.position.y, Input.GetAxis("Mouse Y"), ref moveVelocityV, .1f);

        //Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = (pos);

        //Vertical Player Movement
        moveVelocityV = moveSpeed * Input.GetAxisRaw("Vertical");
        //Horizontal Player Movement, Calculate Move Velocity, Allow the Rigidbody component to use the input velocity.
        moveVelocityH = moveSpeed * Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityH, moveVelocityV);

        
    }

    
}
