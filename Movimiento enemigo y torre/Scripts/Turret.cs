using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private float rotationSpeed = 20f;

    //Shooting variables
    private float fireRate = 1f;
    private float fireTime = 0f;
    private float damage = 5f;
    private float range = 5f;

    //Enemy target
    string enemyTag = "Enemy";
    private GameObject closestEnemy;
    private float closestDistance;
    Enemy enemy;

    void Start()
    {
        InvokeRepeating("UpdateEnemy", 0.0f, 0.5f);
    }

    void UpdateEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        closestDistance = Mathf.Infinity;
        foreach (GameObject enemy in enemies){
            float distance = Vector3.Distance(enemy.transform.position, transform.position);

            if(distance < closestDistance) 
            {
                closestEnemy = enemy;
                closestDistance = distance;
            }
        }
    }


    void Update()
    {
        if (closestDistance < range)
        {
            Vector3 direction = closestEnemy.transform.position - transform.position;
            direction.y = 0;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotationSpeed);

            if(fireTime <= 0)
            {
                Shoot();
                fireTime = fireTime / fireRate;
            }

            fireTime -= Time.deltaTime;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    void Shoot()
    {

    }
}
