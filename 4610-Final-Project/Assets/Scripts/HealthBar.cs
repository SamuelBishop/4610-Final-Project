using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Transform target;
    
    public Slider slider;

    // void Start()
    // {
    //     SetMaxHealth(10);
    // }

    // public void SetMaxHealth(int health)
    // {
    //     slider.maxValue = health;
    //     slider.value = health;
    // }

    void Update()
    {
        var playerHealth = target.GetComponent<Health>();
        SetHealth(playerHealth.currentHealth);
    }

    // Start is called before the first frame update
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
