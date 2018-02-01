using UnityEngine;

public class Enemy2 : MonoBehaviour {

	public int currentHP2 = 3;

	public void TakeDamage2( int damageAmount)
	{
		currentHP2 -= damageAmount;
		if (currentHP2 <= 0)
		{
			GameController.killScore = GameController.killScore+3;
			Destroy(gameObject);
		}
	}
}
