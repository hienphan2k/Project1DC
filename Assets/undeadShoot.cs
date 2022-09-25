using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class undeadShoot : MonoBehaviour {

	public GameObject theBom;
	public Transform shootForm;
	public float shootTime;

	float nextShoot = 0f;
	Animator undeadAnim;

	void Awake(){
		undeadAnim = GetComponentInChildren<Animator> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player" && Time.time > nextShoot) {
			nextShoot = Time.time + shootTime;
			Instantiate (theBom, shootForm.position, Quaternion.identity);
			undeadAnim.SetTrigger ("undeadShoot");
		}
	}
}
