using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int startingHealth = 3;
    [SerializeField] GameObject targetObject;
    public int currentHealth;
    private int dead = 0;

    // Start is called before the first frame update
    private void OnEnable()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if(currentHealth <= 0 && dead == 0){
            Die();
        }
    }

    public void Die()
    {
        dead = 1;
        var deathHandler = targetObject.GetComponent<GameOverScript>();
        if (targetObject.name == "wizard_macanim DEMO"){
            deathHandler.HandleDeath();
        }
        else
        {
            targetObject.SetActive(false);
        }
        
    }
}
