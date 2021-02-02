using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    public GameManager gameManager;

    public void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "Meteor")
        {
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().GameOver();
            }

        }
    }
}
