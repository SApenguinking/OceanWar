using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haiou_move : MonoBehaviour {
	private bool flag;
	Vector3 speed;
	Vector3 direction;

	void Start()  
	{  
		speed = new Vector3(0, 0, 0.3f);

		direction = new Vector3 (0, 180, 0);
		flag = true;
	}  

	// Update is called once per frame
	void FixedUpdate () {
		if (this.transform.position.x > 35) {
			if (flag)
			this.transform.Rotate (direction);
			flag = false;
		} else if (this.transform.position.x < -35) {
			if (!flag)
			this.transform.Rotate (direction);
			flag = true;
		}

			this.transform.Translate (speed);
	}
}
