using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem4 : MonoBehaviour
{
    // Tombol untuk menggerakkan ke atas
    public KeyCode upButton = KeyCode.UpArrow;

    // Tombol untuk menggerakkan ke bawah
    public KeyCode downButton = KeyCode.DownArrow;

    // Tombol untuk menggerakkan ke kanan
    public KeyCode rightButton = KeyCode.RightArrow;

    // Tombol untuk menggerakkan ke kiri
    public KeyCode leftButton = KeyCode.LeftArrow;

    // Kecepatan gerak
    public float speed = 10.0f;

    // Batas atas dan bawah game scene (Batas bawah menggunakan minus (-))
    public float yBoundary = 9.0f;

    // Batas kiri dan atas game scene (Batas bawah menggunakan minus (-))
    public float xBoundary = 9.0f;

    // Rigidbody 2D
    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Dapatkan kecepatan raket sekarang.
        Vector2 velocity = rigidBody2D.velocity;

        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }

        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }

        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.y = 0.0f;
        }

        // Jika pemain menekan tombol ke kanan, beri kecepatan positif ke komponen x (ke kanan).
        if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }

        // Jika pemain menekan tombol ke kanan, beri kecepatan positif ke komponen x (ke kanan).
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }

        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.x = 0.0f;
        }

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

        // Dapatkan posisi raket sekarang.
        Vector3 position = transform.position;
    }
}
