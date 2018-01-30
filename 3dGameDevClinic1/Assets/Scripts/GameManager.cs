using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static int Health;
	public Text healthCount;


	public int waveCount;

	void Start () {
		Health = 10;
	}
	

	void Update () {
		healthCount.text = "Health: " + Health.ToString ();
	}
}
