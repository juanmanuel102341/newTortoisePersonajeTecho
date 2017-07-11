using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
	private Rigidbody rigid;

	public float velocidad;
	public float velocityRotation;

	public float sensibilidadSalidaTecho;
	public float sensibilidadEntradaTecho;
	private bool activeTecho;
	private bool salidaTecho;
	private bool entradaTecho;
	private MeshRenderer mesh;
	private float tiempo;


	void Start () {
		rigid=GetComponent<Rigidbody>();
		activeTecho=false;
		salidaTecho=false;
		entradaTecho=false;
	}
	
	// Update is called once per frame
	void Update () {
		if(salidaTecho){
		tiempo+=Time.deltaTime;
			print("tiempo "+tiempo);
		}
		if(tiempo>sensibilidadSalidaTecho){
			print("salida activa");

			tiempo=0;
			activeTecho=false;
			mesh.enabled=true;
			salidaTecho=false;
		}


		if(Input.GetKey(KeyCode.W)&&transform.position.x<50&&transform.position.x>-48){
			

			rigid.transform.Translate(Vector3.forward*velocidad*Time.deltaTime);
		
			RaycastHit rayo;
			if(Physics.Raycast(transform.position,Vector3.up,out rayo)){
				activeTecho=true; 

			
				mesh=rayo.transform.gameObject.GetComponent<MeshRenderer>();
				mesh.enabled=false;
			}else if(mesh!=null){
				print("salida techo");
				if(activeTecho){
					salidaTecho=true;
				}
			
			}
		}else if(Input.GetKey(KeyCode.S)&&transform.position.x<50&&transform.position.x>-48){
			rigid.transform.Translate(Vector3.back*velocidad*Time.deltaTime);
			RaycastHit rayo;
			if(Physics.Raycast(transform.position,Vector3.up,out rayo)){
				activeTecho=true; 
			
			
				MeshRenderer mesh=rayo.transform.gameObject.GetComponent<MeshRenderer>();
				mesh.enabled=false;
			}else if(mesh!=null){
				print("salida techo");
				//mesh.enabled=true;
				if(activeTecho){
				salidaTecho=true;
				}
				}
			}
		if(Input.GetKey(KeyCode.A)){
			rigid.transform.Rotate(Vector3.up*-velocityRotation*Time.deltaTime);
		}else if(Input.GetKey(KeyCode.D)){
			rigid.transform.Rotate(Vector3.up*velocityRotation*Time.deltaTime);
		}
		
	}

}
