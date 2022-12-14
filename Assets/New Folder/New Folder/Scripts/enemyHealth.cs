using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour {

	public float maxHealth;
	float currentHealth;

	// Bien de tao hieu ung khi enemy die
	public GameObject enemyHealthEF;

	//Khai bao cac bien de tao thanh mau cho enemy
	public Slider enemyHealthSlider;

	//Kb cac bien de khi enemy chet se roi ra vien mau;
	public bool drop;
	public GameObject theDrop;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;

		enemyHealthSlider.maxValue = maxHealth;
		enemyHealthSlider.value = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addDamge(float damage){
		enemyHealthSlider.gameObject.SetActive (true);
		currentHealth -= damage;
		enemyHealthSlider.value = currentHealth;
		if (currentHealth <= 0)
			makeDead ();
	}

	void makeDead(){
		Destroy (gameObject);
		Instantiate (enemyHealthEF, transform.position, transform.rotation);
		// Chuc nang roi ra vien mau
		if (drop) {
			Instantiate (theDrop, transform.position, transform.rotation);
		}
	}
}
