using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xuanchuan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BoardApp() {
		if (!gameObject.activeSelf)
		gameObject.SetActive (true);
	}

	public void BoardDis() {
		if (gameObject.activeSelf)
		gameObject.SetActive (false);
	}
}
