using System.Collections;
using UnityEngine;


public class CollisionCheckBahn : MonoBehaviour
{
    public AudioClip fahrkarten;
    public SceneTransitionManager SceneTransitionManager;

    public RuntimeAnimatorController postCollisionAnimation;
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Animator animator = gameObject.GetComponent<Animator>();
            animator.runtimeAnimatorController = postCollisionAnimation;
            GetComponent<NPCFollow>().enabled = false;
            GetComponent<AudioSource>().clip = fahrkarten;
            GetComponent<AudioSource>().Play();
            StartCoroutine(NextScene());

        }
        IEnumerator NextScene()
        {
            yield return new WaitForSeconds(6);
            SceneTransitionManager.GoToScene(2);
            
        }
    }
}
