using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStartPosition : MonoBehaviour {

    //Vertical Space Object Movement For lerp
    public float moveSpeedY;
    public Transform point1;
    public Transform point2;

    private Vector3 pos1;
    private Vector3 pos2;
    // Use this for initialization
    void Start ()
    {

        pos1 = new Vector3(point1.transform.position.x, point1.transform.position.y, 0f);
        pos2 = new Vector3(point2.transform.position.x, point2.transform.position.y, 0f);

    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(moveSpeedY * Time.time) + 1.0f) / 2.0f);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
