using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonControl : MonoBehaviour {

    /*
    private Vector2 currentPosition;
    private Vector2 newPosition;
    private Vector2 direction;
    private Vector3 velocity;
    */

    private float moveVelocityV;
    private float moveVelocityH;
    private float moveSpeed;

    private float mouseSpeedV;
    private float mouseSpeedH;

    // Use this for initialization
    void Start ()
    {
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update ()
    {

        


	}

    private void FixedUpdate()
    {
        //Tests
        /* //Use Vector3's to get the mouse positioning on screen to convert it to a point.
         Ray onScreenMousePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;

         if (Physics.Raycast(onScreenMousePosition, out hit))
         {
             currentPosition = transform.position;
             newPosition = new Vector2(hit.point.x, transform.localScale.y / 2);
             velocity = currentPosition - newPosition;
             GetComponent<Rigidbody2D>().MovePosition(newPosition);
         }
         */

        
        mouseSpeedV = Input.GetAxisRaw("Mouse Y") / Time.fixedDeltaTime - 1.1f;
        mouseSpeedH = Input.GetAxisRaw("Mouse X") / Time.fixedDeltaTime - 1.1f;
        GetComponent<Rigidbody2D>().velocity = new Vector2(mouseSpeedH, mouseSpeedV);


    }
}
