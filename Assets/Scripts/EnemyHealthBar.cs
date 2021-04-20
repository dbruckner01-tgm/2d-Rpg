using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EnemyHealthBar : MonoBehaviour
{

    public Slider slider;

    public TextMeshProUGUI currentHealth;
    public TextMeshProUGUI maxHealth;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        currentHealth.SetText(Convert.ToString(health));
        maxHealth.SetText(Convert.ToString(health));
       
    }


    public void SetHealth(int health)
    {
        slider.value = health;
        currentHealth.SetText(Convert.ToString(health));
    }
}
