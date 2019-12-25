using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float spawnMinWait = 0.5f;
    [SerializeField] float spawnMaxWait = 1f;

    [SerializeField] List<GameObject> attackerList;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(spawnMinWait, spawnMaxWait));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        var newAttacker = Instantiate(attackerList[Random.Range(0, attackerList.Count)], transform.position, Quaternion.identity);
    }
}
