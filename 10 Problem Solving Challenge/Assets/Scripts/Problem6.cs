using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem6 : MonoBehaviour
{
    public GameObject Square;
    float randomPositionX;
    float randomPositionY;
    // Start is called before the first frame update
    void Start()
    {
        float countSpawn = Random.Range(5,25);
        for (int i = 0; i < countSpawn; i++)
        {
            randomPositionX = Random.Range(-12f,12f);
            randomPositionY = Random.Range(-6f,6f);
            transform.position = new Vector2(randomPositionX, randomPositionY);
            Instantiate(Square, transform.position, Quaternion.identity);
        }
        Invoke("Start",3);
    }
}
