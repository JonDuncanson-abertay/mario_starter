using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// variables taken from CharacterController.Move example script
	// https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	public int Lives = 3; // number of lives the player hs

    private Rigidbody rb = null;
	Vector3 start_position; // start position of the player


	void Start()
	{
		// record the start position of the player
		start_position = transform.position;
        rb = GetComponent<Rigidbody>();
	}


    void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint contact in collision.contacts)
        {

            Debug.Log("save me");
        }

    }


    public void Reset()
	{
		// reset the player position to the start position
		transform.position = start_position;
	}


    void FixedUpdate()
    {
        rb.freezeRotation = true;


    }

	void Update()
	{
		// get the character controller attached to the player game object
		CharacterController controller = GetComponent<CharacterController>();


		// check to see if the player is on the ground
		if (controller.isGrounded) 
		{
			// set the movement direction based on user input and the desired speed
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			// check to see if the player should jump
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
		}

		// apply gravity to movement direction
		moveDirection.y -= gravity * Time.deltaTime;

		// make the call to move the character controller
		controller.Move(moveDirection * Time.deltaTime);

       
    }


    

    //void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    SphereCollider temp = GetComponent<SphereCollider>();

        

    //}
    //void OnControllerColliderHit(SphereCollider hit)
    //{
    //    // find out what we've hit

    //    //  private GameObject sphere = getgame;
    //    Collider sphere = GetComponent<SphereCollider>();

    //    if (hit.collider.sph)
    //    {
    //        Debug.Log("hit head");

    //    }

    //}
}