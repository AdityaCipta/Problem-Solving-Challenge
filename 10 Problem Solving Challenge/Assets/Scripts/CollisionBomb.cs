using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionBomb : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject GameOverPanel;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Bomb"){
            movement.speed = 0;
            GameOverPanel.SetActive(true);
        }
    }
}
