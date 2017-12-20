using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidController : MonoBehaviour {

	// Use this for initialization
	public float tumble;
	public Rigidbody rigidbody;
	void Start () 
	{
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
