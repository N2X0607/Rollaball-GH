using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


// This script is still a work in progress, its the main reason as to why my prototype didn't play properly as I had intended


public class Moveset : MonoBehaviour
{
   
    
    public DamageState myScript;
    
//This part is the setback, I cannot get the Opponent game object to respond to attack mode (damage state) properly without having to create an entirely new boolean. I need to find a way to access the initial AttackMode boolean from this script


    public bool AttackMode;
    
    public GameObject Player;
    public GameObject PickUp;
    
    
    NavMeshAgent agent;
    

    // Start is called before the first frame update
    void Start()
    {
        
	myScript = GetComponent<DamageState>();  
	agent = GetComponent<NavMeshAgent>(); 
	


    }

    // Update is called once per frame
    void Update()
    {

	// Moves the opponent towards either a powerup or the player, depending on if it 	   is in damage state
       
	if(AttackMode == false)
	{
	
	agent.destination = PickUp.transform.position;
	}


	if(AttackMode == true)
	{

	agent.destination = Player.transform.position;
	}

    }




    


}

