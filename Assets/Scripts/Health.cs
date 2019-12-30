using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 50;
    [SerializeField] GameObject deathVFX;
    [SerializeField] float durationOfDeath = 5f;

    public void DealDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (deathVFX == null) { return; }

        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        deathVFXObject.transform.position.Set(transform.position.x, transform.position.y, -1f);
        Destroy(deathVFXObject, durationOfDeath);
    }
}
