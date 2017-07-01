using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Character
{
    readonly int DEFAULTHEALTH = 20;
    readonly int DEFAULTSTRENGTH = 30;
    int strength;
    int maxHealth;
    int currentHealth;

    public Fighter()
    {
        maxHealth = DEFAULTHEALTH;
        currentHealth = DEFAULTHEALTH;
        strength = DEFAULTSTRENGTH;
    }

    public Fighter(int strength, int maxHealth)
    {
        this.maxHealth = maxHealth;
        this.strength = strength;
        currentHealth = maxHealth;
    }

    public void attack(Fighter c, int damage)
    {
        c.takeDamage(damage);
    }

    public void takeDamage(int damage)
    {
        if (currentHealth - damage < 1) die();
        else currentHealth -= damage;
    }

    public void heal(int health)
    {
        if (health + currentHealth > maxHealth) currentHealth = maxHealth;
        else currentHealth += health;
    }

    private void die()
    {
        currentHealth = 0;
    }
		
}
