using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int startingHealth = 3;
    private int currentHealth;

    // Start is called before the first frame update
    private void OnEnable()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if(currentHealth <= 0){
            Die();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
