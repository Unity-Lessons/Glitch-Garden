using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 50;
    //[SerializeField] GameObject deathVFX;
    [SerializeField] float durationOfDeath = 1f;

    public void DealDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
            Death();
    }

    private void Death()
    {
        Destroy(gameObject);
        //GameObject attckerExplosion = Instantiate(deathVFX, gameObject.transform.position, transform.rotation);
        //Destroy(attckerExplosion, durationOfDeath);
    }
}
