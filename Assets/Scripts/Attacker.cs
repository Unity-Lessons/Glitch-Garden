using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    bool readyToMove = false;
    [Range(0f, 2f)]
    [SerializeField] float walkSpeed = 1.0f;
    [SerializeField] new Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpawnIn(animation));
    }

    // Update is called once per frame
    void Update()
    {
        if (!readyToMove)
            Movement();
    }

    private void Movement()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }

}
