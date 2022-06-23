using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerCollusion : MonoBehaviour
{    
    public PlayerMovement pw;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {            
            pw.enabled = false;            
            FindObjectOfType<GameManager>().endGame();
        }

    }
}
