using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    public GameObject Apple;
    public GameObject Berry;
    public GameObject Strawberry;
    float randomPositionX;
    float randomPositionY;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnApple", 3, 3);
        InvokeRepeating ("SpawnBerry", 8, 8);
        InvokeRepeating ("SpawnStrawberry", 10, 10);
    }

    public void SpawnApple()
    {
        float countSpawn = Random.Range(3,5);
        for (int i = 0; i < countSpawn; i++)
        {
            randomPositionX = Random.Range(-4f,4f);
            randomPositionY = Random.Range(-2f,2f);
            transform.position = new Vector2(randomPositionX, randomPositionY);
            Instantiate(Apple, transform.position, Quaternion.identity);
        }
    }

    public void SpawnBerry()
    {
        float countSpawn = Random.Range(3,5);
        for (int i = 0; i < countSpawn; i++)
        {
            randomPositionX = Random.Range(-12f,12f);
            randomPositionY = Random.Range(-6f,6f);
            transform.position = new Vector2(randomPositionX, randomPositionY);
            Instantiate(Berry, transform.position, Quaternion.identity);
        }
    }

    public void SpawnStrawberry()
    {
        float countSpawn = Random.Range(3,5);
        for (int i = 0; i < countSpawn; i++)
        {
            randomPositionX = Random.Range(-16f,16f);
            randomPositionY = Random.Range(-8f,8f);
            transform.position = new Vector2(randomPositionX, randomPositionY);
            Instantiate(Strawberry, transform.position, Quaternion.identity);
        }
    }
}
