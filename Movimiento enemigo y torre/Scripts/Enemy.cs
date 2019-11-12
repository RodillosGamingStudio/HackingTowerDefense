using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform nextPoint;
    private int i = 0;
    private float movementSpeed = 2f;
    private float rotationSpeed = 200f;
    public float lifePoints = 20f;
    private bool rotate = false;

    void Start()
    {
        nextPoint = Turns.turnPositions[0];
    }

    void Update()
    {
        if (!rotate)
        {
            Advance();
            if (Vector3.Distance(transform.position, nextPoint.position) <= 0.2f)
            {
                if (i == Turns.turnPositions.Length - 1) i = 0;
                else i++;

                nextPoint = Turns.turnPositions[i];
                rotate = true;
            }
        }
        else
        {
            Rotate();
        }        
    }

    void Advance()
    {
        Vector3 direction = nextPoint.position - transform.position;
        transform.Translate(direction.normalized * Time.deltaTime * movementSpeed, Space.World);
    }

    void Rotate()
    {
        Quaternion q = Quaternion.LookRotation(nextPoint.position - transform.position);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, rotationSpeed * Time.deltaTime);
        rotate = Quaternion.Angle(q, transform.rotation) >= 1.0f;
    }

    public void receiveDamage(float damage)
    {
        lifePoints -= damage;
        if(lifePoints <= 0)
        {
            Destroy(this);
        }
    }

}
