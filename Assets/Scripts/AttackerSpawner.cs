using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    int index = 0;
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
        index = Random.Range(0, attackerList.Count);
        var newAttacker = Instantiate(attackerList[index], transform.position, Quaternion.identity);
    }
}
