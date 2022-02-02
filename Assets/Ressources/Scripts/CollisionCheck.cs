using UnityEngine;


public class CollisionCheck : MonoBehaviour
{
    public GameObject menu;
    public GameObject moveScript;
    public RuntimeAnimatorController postCollisionAnimation;
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Animator animator = gameObject.GetComponent<Animator>();
            animator.runtimeAnimatorController = postCollisionAnimation;
            moveScript.SetActive(false);
            GetComponent<NPCFollow>().enabled = false;
            menu.SetActive(true);
            
        }
    }
}