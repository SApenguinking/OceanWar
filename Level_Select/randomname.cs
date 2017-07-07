using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomname : MonoBehaviour {
	public UILabel laber;

	private bool _mouseDown;
	private bool flag;

	private int _randnum;
	//RaycastHit hit;

	// Use this for initialization
	void Start () {
		flag = false;
		_randnum = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit))
				if(hit.collider.tag == "shaizi")
					flag = true;
		}
		if (flag) { 
			if (_randnum == 3)
				_randnum = 0; 
			if (_randnum == 0)
				laber.text = "hahaha";
			if (_randnum == 1)
				laber.text = "hehehe";
			if (_randnum == 2)
				laber.text = "xixixi";
			if (_randnum == 3)
				_randnum = 0; 
			_randnum++;
			flag = false;
		}
	}
}
