using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	public float speed;
	public float rotationSpeed;

	public Transform player;

	// Update is called once per frame
	void Update () 
	{
		float step = speed * Time.deltaTime;
		transform.Rotate (new Vector3 (15, 30, 45) * (rotationSpeed * Time.deltaTime));
		transform.position = Vector3.MoveTowards (transform.position, player.position, step);
	}
}
