using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    SpriteRenderer sp;
    DefenderSpawner defSpawn;
    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        defSpawn = FindObjectOfType<DefenderSpawner>();
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
            button.GetComponent<SpriteRenderer>().color = new Color32(125, 125, 125, 255);
        
        sp.color = Color.white;
        defSpawn.UpdateDefender(defenderPrefab);
    }



    
}
