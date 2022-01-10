using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollisionCheck : MonoBehaviour
{
    public GameObject menu;
    public ActionBasedContinuousMoveProvider player;
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("collidedwithplayer");
            player.moveSpeed = 0;
            menu.SetActive(true);
        }
    }
}