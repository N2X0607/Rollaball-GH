using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



//This is just the basic player movement control script from the original Rollaball      tutorial


public class PlayerController : MonoBehaviour
{

	public float speed = 0;
	
	private Rigidbody rb;
	
	private float movementX;
	private float movementY;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue)
    {

	Vector2 movementVector = movementValue.Get<Vector2>();
	
	movementX = movementVector.x;
	movementY = movementVector.y;

     }
    
    private void FixedUpdate()
    {

	Vector3 movement = new Vector3(movementX, 0.0f, movementY);
	
	rb.AddForce(movement * speed);




    }




// Update is called once per frame
    void Update()
    {
      
    }
}
