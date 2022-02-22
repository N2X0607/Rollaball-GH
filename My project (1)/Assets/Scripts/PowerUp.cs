using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//This script establishes how the powerup will consumed by both the player and opponent


public class PowerUp : MonoBehaviour
{
    	
	
	//This function has the powerup react when being picked up by both the player and 	  the opponent, utilizing a collider and the trigger function of the powerup

	
	void OnTriggerEnter (Collider other)
	{
	
		if(other.CompareTag("Player"))
		{
		 Pickup();

		 		
		}
		
		
		if(other.CompareTag("Opponent"))
		{
		 Pickup();

		 		
		}		
	
	}

	
	// Destroys the powerup once it has been picked up

	void Pickup()
	{
	 Destroy(gameObject);
	}



	
}
