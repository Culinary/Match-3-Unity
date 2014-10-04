using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gem : MonoBehaviour {

	public string[] gemNames = {"Blue Gem", "Green Gem", "Purple Gem", "Red Gem", "Yellow Gem"};
	public string color = "";
	public GameObject test;

	// Use this for initialization
	void Start () {

		CreateGem ();

	}

	// Update is called once per frame
	void Update () {
	}

	void CreateGem() {
		
		color = gemNames[Random.Range (0,gemNames.Length)];
		GameObject gemPrefab = Resources.Load("Prefabs/"+color) as GameObject;
		test = (GameObject)Instantiate (gemPrefab,Vector3.zero,Quaternion.identity);
		test.transform.parent= transform;
		test.transform.localPosition = Vector3.zero;
	}
}
