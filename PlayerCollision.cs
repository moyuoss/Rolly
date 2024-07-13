using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Game Over
            PlayerManager.gameOver = true;
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            PlayerManager.apples++;
            Destroy(other.gameObject);
        }
    }
}
