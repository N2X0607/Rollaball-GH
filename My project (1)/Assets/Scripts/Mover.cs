using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// The purpose of this script is to move the powerup periodically once it has been spawned


public class Mover : MonoBehaviour

{

	// establishes the variables in which control the movement

	public float targetTime = 5.0f;
	float x;
	float y;
	float z;
	Vector3 pos;
	
    // Start is called before the first frame update
    void Start()
    {

	// Starts the script off by immediately moving the power once it spawns, within 	   the limits of the plane
	
        x = Random.Range(-10, 10);
	y = 0.5f;
	z = Random.Range(-10, 10);
	pos = new Vector3(x, y, z);
	transform.position = pos;    }

    // Update is called once per frame
    void Update()
    {


	//This section establishes the timer, and how powerup will be moved again after a 	  duration of 15 seconds


	targetTime -= Time.deltaTime;
	
        if(targetTime <= 0.0f)
	{
		timerEnded();
	}



	void timerEnded()
	{
	x = Random.Range(-10, 10);
	y = 0.5f;
	z = Random.Range(-10, 10);
	pos = new Vector3(x, y, z);
	transform.position = pos;
	targetTime = 15.0f;
	

	}
    }
}
