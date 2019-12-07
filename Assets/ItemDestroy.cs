using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {
	private GameObject mainCam;
	private Camera cam;

	// Use this for initialization
	void Start () {
		this.mainCam = GameObject.Find ("Main Camera");
		this.cam = this.mainCam.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.cam.transform.position.z) {
			Destroy (this.gameObject);
		}
	}

	//void OnBecameInvisible(){
		//Destroy (this.gameObject);
	//}
}
