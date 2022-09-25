using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomController : MonoBehaviour {

	public float bomSpeedHight;
	public float bomSpeedLow;
	public float bomAngle;

	Rigidbody2D bomRB;

	void Awake(){
		bomRB = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		bomRB.AddForce (new Vector2 (Random.Range (-bomAngle, bomAngle), Random.Range (bomSpeedLow, bomSpeedHight)), ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
