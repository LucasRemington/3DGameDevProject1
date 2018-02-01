using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject[] enemies;
	public GameObject gates;
	public int gateHP = 10;
	public int maxWaves = 10;
	public int currentWave = 0;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;
	private WaitForSeconds waveDuration = new WaitForSeconds(2.5f);

	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		WaveMode ();
	}

	void Update()
	{
		
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
