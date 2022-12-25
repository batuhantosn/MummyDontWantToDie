using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject bomb;
    [SerializeField] private GameObject tp;
    [SerializeField] private GameObject tpx2;
    [SerializeField] private float bombSpawnTime;
    [SerializeField] private float tpSpawnTime;
    [SerializeField] private float tpx2SpawnTime;
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(bombSpawnTime, tpSpawnTime, tpx2SpawnTime));
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.score >= 2000)
        {
            bombSpawnTime = 0.5f;
            tpSpawnTime = 0.5f;
        }
        else if (PlayerScript.score >= 1000)
        {
            bombSpawnTime = 1;
            tpSpawnTime = 0.5f;
        }

    }

    IEnumerator ExecuteAfterTime(float bombwaittime,float tpwaittime, float tpx2waittime)
    {
        while (true)
        {
        yield return new WaitForSeconds(bombwaittime);
        bombSpawn();
        yield return new WaitForSeconds(tpwaittime);
        tpSpawn();
        yield return new WaitForSeconds(tpx2waittime);
        tpx2Spawn();

        }
        
    }
    private void bombSpawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 24), 1, Random.Range(0, 12));
        Instantiate(bomb, randomSpawnPosition, Quaternion.identity);
    }
    private void tpSpawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 24), 10, Random.Range(0, 12));
        Instantiate(tp, randomSpawnPosition, Quaternion.identity);
    }
    private void tpx2Spawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 24), 10, Random.Range(0, 12));
        Instantiate(tpx2, randomSpawnPosition, Quaternion.identity);
    }
}
