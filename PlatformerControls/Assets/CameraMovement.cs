using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public Transform target;

    public float camSpeed = 2f;

	void Update () {

        transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x, target.position.y, transform.position.z), Time.deltaTime * camSpeed);

	}
}
