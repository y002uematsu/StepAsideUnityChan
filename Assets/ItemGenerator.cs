﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
	public GameObject carPrefab;
	public GameObject coinPrefab;
	public GameObject conePrefab;
	public GameObject unitychan;
	private int startPos = -160;
	private int goalPos = 120;

	private float posRange = 3.4f;

	float itemGenerationPositionZ;

	// Use this for initialization
	void Start () {
		this.unitychan = GameObject.Find ("unitychan");
		itemGenerationPositionZ = unitychan.transform.position.z + 10f;

		/*for (int i = startPos; i < goalPos; i+=15) {
			int num = Random.Range (1, 11);
			if (num <= 2) {
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y,i);
				}
			}else{
				for (int j = -1; j <= 1; j++) {
					int item = Random.Range (1, 11);
					int offsetZ = Random.Range (-5, 6);

					if (1 <= item && item <= 6) {
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y,i + offsetZ);

					} else if (7 <= item && item <= 9) {
						GameObject car = Instantiate (carPrefab)as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y,i + offsetZ);
					}
				}
			}
		}
	*/}
	
	// Update is called once per frame
	void Update () {
		if (unitychan.transform.position.z > itemGenerationPositionZ) {
			int num = Random.Range (1, 11);
			if (num <= 2) {
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y,unitychan.transform.position.z +40);
				}
			} else {
				for (int j = -1; j <= 1; j++) {
					int item = Random.Range (1, 11);
					int offsetZ = Random.Range (-5, 6);

					if (1 <= item && item <= 6) {
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, unitychan.transform.position.z +40 + offsetZ);

					} else if (7 <= item && item <= 9) {
						GameObject car = Instantiate (carPrefab)as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, unitychan.transform.position.z +40 + offsetZ);
					}
				}
			}
			itemGenerationPositionZ += 15f;
		}
	}
}