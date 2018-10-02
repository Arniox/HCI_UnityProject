using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		gameObject.GetComponent<Rigidbody>().useGravity = true;

		if(gameObject.GetComponent<Rigidbody>().useGravity == true){
			print("gave gravity");
		}
		
	}
}
