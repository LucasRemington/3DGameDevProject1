using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

	public int scope = 1;
	public int noScope = 60;
	float lerp = 33;

	void Update () 
		{
			if (Input.GetButtonDown ("Fire2")) 
				{
					GetComponentInParent<Camera>().fieldOfView = Mathf.Lerp (GetComponent<Camera> ().fieldOfView, scope, Time.deltaTime * lerp);
					//GetComponentInParent<Camera> ().fieldOfView = scope;
				} 
			if (Input.GetButtonUp ("Fire2")) 
				{
					GetComponentInParent<Camera> ().fieldOfView = noScope;
				}
		}
}
