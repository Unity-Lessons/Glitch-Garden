using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Debug.Log("Mouse clicked");
        SpawnDefender();
    }

    private void SpawnDefender()
    {
        Instantiate(defender, transform.position, transform.rotation);
    }
}
