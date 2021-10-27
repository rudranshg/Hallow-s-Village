using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float maxHealth = 33f;
    public float currentHealth;
    public Transform playerTr;
    public Transform enemyTr;
    float distance;
    float maxdamage = 7;
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = (playerTr.position - enemyTr.position).magnitude;
        if(distance<3)
        {
            TakeDamage( maxdamage - distance);
        }
    }
    void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }
}
