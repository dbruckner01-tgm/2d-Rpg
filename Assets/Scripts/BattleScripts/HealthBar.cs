using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public TextMeshProUGUI currentHealth;
    public TextMeshProUGUI maxHealth;

    public manaBar manaBar;



    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        currentHealth.SetText(Convert.ToString(health));
        maxHealth.SetText(Convert.ToString(health));
        fill.color = gradient.Evaluate(1f);
    }


    public void SetHealth(int health)
    {
        if (health < 0)
        {
            health = 0;
        }

        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        currentHealth.SetText(Convert.ToString(health));
    }


    public void setMana(int mana)
    {
        if (mana < 0)
        {
            mana = 0;
        }
    }
}
