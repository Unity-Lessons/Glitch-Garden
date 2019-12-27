using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, firePoint;
    [SerializeField] float speed = 1f;

    public void Fire()
    {
        var newProj = Instantiate(projectile, firePoint.transform.position, Quaternion.identity);
        //newProj.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }
}
