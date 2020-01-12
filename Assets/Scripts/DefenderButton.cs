using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    SpriteRenderer sp;
    DefenderSpawner defSpawn;

    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        defSpawn = FindObjectOfType<DefenderSpawner>();
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
            button.GetComponent<SpriteRenderer>().color = new Color32(65, 65, 65, 255);
        
        sp.color = Color.white;
        defSpawn.UpdateDefender(this.gameObject);
    }



    
}
