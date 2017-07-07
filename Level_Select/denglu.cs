using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class denglu : MonoBehaviour {
	public GameObject obj;
	public Camera _camera;

	private bool flag;

	public Camera _camera_ob;

	// Use this for initialization
	void Start () {
		flag = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = _camera_ob.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit))
			if (hit.collider.tag == "button")
				flag = true;
		}

		if (flag && Input.GetMouseButtonUp (0)) { 
			obj.SetActive (false);
			_camera.depth= 3;
			flag = false;
		}
	}


}
