using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour {
	public GameObject[] obj;
	private float tiempo=0.0f;
	public float limiteX_sup;
	public float limiteX_inf;
	public float limiteZ_sup;
	public float limiteZ_inf;


	public float limiteY;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		tiempo+=Time.deltaTime;

		//print("cajas "+);
		if(tiempo>2.0f){
			int i=Random.Range(0,obj.Length);

			Instantiate(obj[i],new Vector3(Random.Range(limiteX_inf,limiteX_sup),transform.position.y,Random.Range(limiteZ_inf,limiteZ_sup)),transform.rotation);
			tiempo=0.0f;
			print("entrando");

		}		
	}
}
