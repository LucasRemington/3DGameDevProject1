using UnityEngine;

public class Enemy3 : MonoBehaviour {

	public int currentHP3 = 10;

	public void TakeDamage3( int damageAmount)
	{
		currentHP3 -= damageAmount;
		if (currentHP3 <= 0)
		{
			GameController.killScore++;
			Destroy(gameObject);
		}
	}

	private void Update()
	{
		
	}
}
