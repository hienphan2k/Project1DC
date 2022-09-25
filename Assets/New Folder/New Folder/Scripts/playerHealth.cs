using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public float maxHealth;
	float currentHealth;

	public GameObject bloodEffect;

	//KB cac bien UI
	public Slider playerHealthSlider;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;

		playerHealthSlider.maxValue = maxHealth;
		playerHealthSlider.value = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addDamage(float damage){
		if (damage <= 0)
			return;
		currentHealth -= damage;
		playerHealthSlider.value = currentHealth;

		if (currentHealth <= 0)
			makeDead ();
	}

	// Tao chuc nang hoi mau khi an duoc vien mau

	public void addHealth(float healthAmount){
		currentHealth += healthAmount;
		if (currentHealth > maxHealth)
			currentHealth = maxHealth;
		playerHealthSlider.value = currentHealth;
	}

	void makeDead(){
		Instantiate (bloodEffect, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
