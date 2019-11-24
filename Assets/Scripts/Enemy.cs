using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;
    //private float speed;


    public float startHealth = 100;
    private float health;


    public int value = 50;

    public int StolenDataValue;

    public Image healthBar;


    void Start()
    {

        //speed = startSpeed;
        health = startHealth;

    }


    public void TakeDamage(float amount)
    {

        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {

        PlayerStats.Money += value;
        Destroy(gameObject);

        WaveSpawner.EnemiesAlive--;

    }

}
