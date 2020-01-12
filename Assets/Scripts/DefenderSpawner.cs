using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    Defender defender;

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
        //newDefender.transform.localScale = new Vector3(0.8f, 0.8f, 1f);
        Defender newDefender = Instantiate(defender, worldPos, transform.rotation) as Defender;
    }

    public void UpdateDefender(Defender selectedDefender)
    {
        defender = selectedDefender;
    }
}
