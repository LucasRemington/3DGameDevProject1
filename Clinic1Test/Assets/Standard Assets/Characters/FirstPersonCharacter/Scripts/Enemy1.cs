
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    public int currentHP1 = 1;

    public void TakeDamage( int damageAmount)
    {
        currentHP1 -= damageAmount;
        if (currentHP1 <= 0)
        {
            Destroy(gameObject);
        }
    }
}
