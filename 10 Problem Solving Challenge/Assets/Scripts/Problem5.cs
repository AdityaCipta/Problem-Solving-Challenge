using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem5 : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float speed = 10.0f;
    Vector2 LastClicked;

    [SerializeField]
    bool Moving;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LastClicked = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Moving = true;
        }

        if (Moving && (Vector2)transform.position != LastClicked)
        {
            float onward = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, LastClicked, onward);
        }
        else
        {
            Moving = false;   
        }
    }
}
