using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
	
	public float xmin;
	public float xmax;
	public float zmin;
	public float zmax;
}
public class PlayerController : MonoBehaviour {

	public Rigidbody rigidbody;
	public float speed;
	public Boundary boundary;
	public float tilt;
	public GameObject shots;
	public Transform shotsLaser;
	public float FireRate;
	private float nextFire;

	// Use this for initialization
	/*
	*/
	//public Boundary boundary;
	void Start () 
	{
		
	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.velocity = movement * speed;
		rigidbody.rotation =  Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
		rigidbody.position = new Vector3 
		(
				Mathf.Clamp(rigidbody.position.x,boundary.xmin,boundary.xmax), 
			0.0f, 
			Mathf.Clamp(rigidbody.position.z,boundary.zmin,boundary.zmax)
		);
		

	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + FireRate;
			Instantiate(shots, shotsLaser.position, shotsLaser.rotation);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play ();
		}
	}
}
