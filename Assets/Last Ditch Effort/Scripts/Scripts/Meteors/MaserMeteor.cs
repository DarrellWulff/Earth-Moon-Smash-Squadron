using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaserMeteor : MonoBehaviour {

    public Transform startPoint;
    public Transform lastPos;
    public GameObject meteor1Real;
    public GameObject meteor2Real;
    public MeteorLogic meteor;
    public Meteor2Logic meteor2;
    public bool test;

    // Use this for initialization
    void Start ()
    {

        test = meteor.isSmashed;

        

	}
	
	// Update is called once per frame
	void Update ()
    {
        if(meteor1Real.activeSelf == false)
        {
            meteor2Real.transform.position = lastPos.position;

            meteor2Real.SetActive(true);
        }
		if(meteor2.isSmashed2 == true)
        {
            transform.position = startPoint.transform.position;
        }
	}
}
