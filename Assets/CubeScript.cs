using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {
	int count = 0;
	string d = "Hello";

	Vector3 pos = new Vector3(1f, 2f, 5.3f);


	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// If I click the left mouse button.
		if (Input.GetMouseButton (0)) 
		{
			transform.localScale = new Vector3 (transform.localScale.x + 0.01f, transform.localScale.y, transform.localScale.z);

		}
		if (Input.GetMouseButton (1)) {
			transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y + 0.01f, transform.localScale.z);
		}

	}
	void OnMouseDown()
	{
		count = count+1;
		// This is a comment. It doesn't do anything. It is useful for explaining.
	//	if (count == 10) {
	//		Debug.Log (transform.position.y);
	//	}   

	}
}
