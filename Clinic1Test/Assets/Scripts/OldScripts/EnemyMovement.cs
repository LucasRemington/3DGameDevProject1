using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public GameObject target1;
	public GameObject target2;
	public GameObject target3;
	public GameObject target4;
	public GameObject target5;
	public GameObject target6;
	public Transform trans1;
	public Transform trans2;
	public Transform trans3;
	public Transform trans4;
	public Transform trans5;
	public Transform trans6;
	Transform target;

	public int pinTarget;
	public float speed;

	public int finalLoopNumber;
	private int loopNumber;
	public bool loopPinPath;

	public bool spawnOne = true;

	void Start () {
		SetTargets ();
	}

	void Awake () {
		SetTargets ();
	}

	void OnTriggerEnter(Collider other) {
		
		if(other.gameObject.tag == "Pin") {
			pinTarget = pinTarget + 1;
			Debug.Log("ChangedPinPath");
		}

		if(other.gameObject.tag == "Goal") {
			Destroy(gameObject);
			GameManager.Health--;
			Debug.Log("Damage");
		}
			
	}

	void OnTriggerStay(Collider other) {

		if(other.gameObject.tag == "Spawn1") {
			spawnOne = true;
		}

		if(other.gameObject.tag == "Spawn2") {
			spawnOne = false;
		}
	}


	void FixedUpdate () {
		float step = speed * Time.deltaTime;
		if (pinTarget == 1 && spawnOne == true) {
			transform.position = Vector3.MoveTowards (transform.position, trans1.position, step);
		} else if (pinTarget == 2 && spawnOne == true) {
			transform.position = Vector3.MoveTowards (transform.position, trans2.position, step);
		} else if (pinTarget == 3 && spawnOne == true) {
			transform.position = Vector3.MoveTowards (transform.position, trans3.position, step);

		} else if (pinTarget == 1 && spawnOne == false) {
			transform.position = Vector3.MoveTowards (transform.position, trans4.position, step);
		} else if (pinTarget == 2 && spawnOne == false) {
			transform.position = Vector3.MoveTowards (transform.position, trans5.position, step);
		} else if (pinTarget == 3 && spawnOne == false) {
			transform.position = Vector3.MoveTowards (transform.position, trans6.position, step);
		}
			

		if (loopPinPath == true && pinTarget > 7) {
			pinTarget = 1;
			if (loopNumber < finalLoopNumber) {
				loopNumber++;
			} else {
				loopPinPath = false;
			}
		}
	}

		void SetTargets () {
		pinTarget = 1;
		loopNumber = 0;
		Debug.Log("targets" +
			"woo");
		target1 = GameObject.Find("Pin1");
		trans1 = target1.transform;

		target2 = GameObject.Find("Pin2");
		trans2 = target2.transform;

		target3 = GameObject.Find("Pin3");
		trans3 = target3.transform;

		target4 = GameObject.Find("Pin4");
		trans4 = target4.transform;

		target5 = GameObject.Find("Pin5");
		trans5 = target5.transform;

		target6 = GameObject.Find("Pin6");
		trans6 = target6.transform;
	}
}
