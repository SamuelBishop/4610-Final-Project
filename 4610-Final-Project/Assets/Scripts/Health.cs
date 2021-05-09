using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int startingHealth = 3;
    [SerializeField] GameObject targetObject;
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
        var deathHandler = targetObject.GetComponent<GameOverScript>();
        if (targetObject.name == "wizard_macanim Demo"){
            deathHandler.HandleDeath();
        }
        targetObject.SetActive(false);
    }
}
