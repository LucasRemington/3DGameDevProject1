using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject[] enemies;
	public GameObject gates;
	public static int gateHP = 10;
	public int maxWaves = 10;
	public int currentWave = 0;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;
	private WaitForSeconds waveDuration = new WaitForSeconds(2.5f);
	public static int killScore = 0;
	public Text gateHealthcount;
	public Text killScorecount;
	public Text waveCount;

	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		WaveMode ();
	}

	void Update()
	{
		gateHealthcount.text = "Health: " + gateHP.ToString ();
		waveCount.text = "Wave " + currentWave.ToString ();
		killScorecount.text = "Score: " + killScore.ToString ();
	}

	private IEnumerator WaveMode()
	{
		while (maxWaves >= currentWave)
		{
			yield return waveDuration;
			spawnTime = spawnTime * 0.85f;
			currentWave++;
		}

	}

	void Spawn()
	{
		if (gateHP <= 0)
			{
				return;
			}
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		int enemiesIndex = Random.Range (0, enemies.Length);
		Instantiate (enemies [enemiesIndex], spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
}
