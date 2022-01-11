using UnityEngine;


public class CollisionCheck : MonoBehaviour
{
    public GameObject menu;
    public GameObject moveScript;
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.CompareTag("Player"))
        {
            moveScript.SetActive(false);
            menu.SetActive(true);
        }
    }
}