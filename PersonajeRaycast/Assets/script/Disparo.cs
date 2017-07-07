using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
	public float FuerzaDisparo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			RaycastHit algo;
			if(Physics.Raycast(transform.position,transform.up,out algo)){
				algo.rigidbody.AddForceAtPosition(transform.up*FuerzaDisparo,algo.point,ForceMode.Impulse);
			//	print("nombre "+algo.transform.name);
				Destroy(algo.transform.gameObject,1.0f);
			}

		}
	
	
	}
}
