using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    public float Health { get; set; }
    // Temporary
    private bool isBossFight = false;
    [SerializeField] private int maxHealth = 5;

    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(float amount)
    {
        if (isBossFight)
        {
            Health -= amount;

            if (Health <= 0)
            {
                Die();
            }
        }
        else
        {
            // Decrement Kill Count
            Debug.Log("Player Damaged");
            KillBudget.instance.DecrementKillBudget(1);
        }
    }

    void Die()
    {
        // To Do: GameOver
    }
}
