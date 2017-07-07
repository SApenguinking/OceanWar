using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousedrag : MonoBehaviour {
	
	public Transform obj;  
	public float speed;  

	private bool _mouseDown;
	private bool flag;

	private float fMouseX;
	private float fMouseY;

	public Camera _camera;
	// Use this for initialization
	void Start () {
		speed = 5;
		_mouseDown = false;
		flag = false;
	}
	
	// Update is called once per frame

	void Update ()   
	{  
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = _camera.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit))
			if (hit.collider.tag == "boat")
				flag = true;
		}

		if (Input.GetMouseButtonDown(0))  
			_mouseDown = true;  
		else if (Input.GetMouseButtonUp(0))  {
			_mouseDown = false;  
			flag = false; }


		if (_mouseDown && flag)  
		{  
			fMouseX = Input.GetAxis("Mouse X");  
			fMouseY = Input.GetAxis("Mouse Y");  
			obj.Rotate(0, -fMouseX * speed, 0);  
		}  
	}  
}  

