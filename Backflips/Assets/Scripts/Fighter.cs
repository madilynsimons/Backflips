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

    public class AttackList
    {
        public class Attack
        {
            readonly string DEFAULTTITLE = "nameless";
            readonly int DEFAULTPP = 20;
            readonly int DEFAULTDAMAGE = 10;
            string title;
            int maxPP, currentPP;
            int damage;

            public Attack()
            {
                title = DEFAULTTITLE;
                maxPP = DEFAULTPP;
                currentPP = DEFAULTPP;
                damage = DEFAULTDAMAGE;
            }

            public Attack(string title, int pp, int damage)
            {
                this.title = title;
                maxPP = pp;
                currentPP = pp;
                this.damage = damage;
            }

            public static bool operator ==(Attack a, Attack b)
            {
                return a.title == b.title && a.maxPP == b.maxPP && a.damage == b.damage;
            }

            public static bool operator !=(Attack a, Attack b)
            {
                return !(a.title == b.title && a.maxPP == b.maxPP && a.damage == b.damage);
            }
        }//end of Attack class

    }//end of AttackList class
}
