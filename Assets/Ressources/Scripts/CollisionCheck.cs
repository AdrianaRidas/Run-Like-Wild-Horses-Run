using UnityEditor.Animations;
using UnityEngine;


public class CollisionCheck : MonoBehaviour
{
    public GameObject menu;
    public GameObject moveScript;
    public AnimatorController postCollisionAnimation;
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.CompareTag("Player"))
        {
            Animator animator = gameObject.GetComponent<Animator>();
            animator.runtimeAnimatorController = postCollisionAnimation;
            moveScript.SetActive(false);
            menu.SetActive(true);
        }
    }
}