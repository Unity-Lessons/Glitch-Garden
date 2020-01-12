using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    [SerializeField] List<GameObject> defenders;
    string n_defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        int i = 0;
        for (i = 0; i < defenders.Count; i++)
        {
            if (defenders[i].name == n_defender)
            {
                break;
            }
        }
        var newDefender = defenders[i];
        //newDefender.transform.localScale = new Vector3(0.8f, 0.8f, 1f);
        newDefender = Instantiate(defenders[i], worldPos, transform.rotation) as GameObject;
    }

    public void UpdateDefender(GameObject selectedDefender)
    {
        n_defender = selectedDefender.name;
    }
}
