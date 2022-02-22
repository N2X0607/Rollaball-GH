using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script establishes the damage state, which allows the opponent or the player to damage each other when picking up a power. This state only lasts for 7 seconds



public class DamageState : MonoBehaviour
{
    
	//This section establishes the damage state, and the duration it will last

	public bool AttackMode = false;
	public float duration = 7f;


        // Activates the damage state when either the player or the opponent make contact     	   with the powerup

	void OnTriggerEnter (Collider other)
	{
	
		if(other.CompareTag("PickUp"))
		{
		 

		 StartCoroutine(Empowered());		
		}
		
		
			
	
	}

	
	



	// Employs the empowered functions, which turns the damage state on for 7 seconds,    	   then turns the wielder back to normal

	IEnumerator Empowered() 
	{
	AttackMode = true;

	yield return new WaitForSeconds(duration);

	AttackMode = false;
	}







}
