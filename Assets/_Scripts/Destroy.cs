using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerexplosion;
	public GameObject player;
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		if (other.tag == "Player")
		{
			Instantiate(playerexplosion, other.transform.position, other.transform.rotation);
		}
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}

}
