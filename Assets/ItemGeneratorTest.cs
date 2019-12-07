using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneratorTest : MonoBehaviour {
	GameObject unitychan;
	float itemGenerationPositionZ;

	// Use this for initialization
	void Start () {
		unitychan = GameObject.Find("unitychan");
		itemGenerationPositionZ = unitychan.transform.position.z + 10f;
	}
	
	// Update is called once per frame
	void Update () {
		if (unitychan.transform.position.z > itemGenerationPositionZ){
			Debug.Log("アイテムを一列生成する");
			itemGenerationPositionZ += 15f;
	}
}
}