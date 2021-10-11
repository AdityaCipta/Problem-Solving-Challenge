using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{
    public GameObject Bomb;
    float randomPositionX;
    float randomPositionY;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBomb",15, 10);
    }

    public void spawnBomb()
    {
        float countSpawn = Random.Range(1,3);
        for (int i = 0; i < countSpawn; i++)
        {
            randomPositionX = Random.Range(-12f,12f);
            randomPositionY = Random.Range(-6f,6f);
            transform.position = new Vector2(randomPositionX, randomPositionY);
            Instantiate(Bomb, transform.position, Quaternion.identity);
        }
    }
}
