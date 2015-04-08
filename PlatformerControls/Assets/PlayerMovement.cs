using UnityEngine;
using System.Collections;

enum Direction
{
    left,
    right
}

public class PlayerMovement : MonoBehaviour {

    



    public KeyCode[] left, right, jump;

    public float jumpHeight;
    public float walkSpeed;


    private Rigidbody rigidbody;

	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	
	void Update () {
        // Handle all the possible input codes for player movement

        // Pressing left key
        for(int i = 0; i < left.Length; i++)
        {
            if (Input.GetKey(left[i]))
                MoveDirection(Direction.left);
        }

        // Pressing right key
        for (int i = 0; i < right.Length; i++)
        {
            if (Input.GetKey(right[i]))
                MoveDirection(Direction.right);
        }

        // Pressing jump
        for (int i = 0; i < jump.Length; i++)
        {
            if (Input.GetKeyDown(jump[i]))
                Jump();
        }
	}

    void MoveDirection(Direction direction)
    {

    }

    void Jump()
    {
        rigidbody.AddForce(Vector3.up * jumpHeight);
    }


}
