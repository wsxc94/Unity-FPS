using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyFactory = null;
    public Transform spawnPoint = null;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());   
    }

    private IEnumerator Spawn()
    {
        
            GameObject enemy = Instantiate(enemyFactory, spawnPoint.transform.position, Quaternion.identity);

            yield return new WaitForSeconds(3f);
        

    }
}
