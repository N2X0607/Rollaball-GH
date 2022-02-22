using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script is for the empty game object that spawns the powerup periodically


public class Spawner : MonoBehaviour
{

// The myPrefab Gameobject allows me to have the spawner spawn the prefab I made of the powerup

  public float targetTime = 10.0f;
  public GameObject myPrefab;  
  
  void Start()
  {

  // Spawns a powerup in the corner of the map, the initial placement doesn't really  	matter as the powerup moves immediately after spawning


  Instantiate(myPrefab, new Vector3(12,1,0), Quaternion.identity); 	


  }


  void Update()
  {
  	// This section has a timer start counting down from 15 seconds, spawning another         	   powerup after its duration ends

	targetTime -= Time.deltaTime;

  	if(targetTime <= 0.0f)
  	{
	timerEnded();
	
	}


	void timerEnded()
	{
	Instantiate(myPrefab, new Vector3(0,0,0), Quaternion.identity);
	targetTime = 15.0f;
	}



  }



  

}
