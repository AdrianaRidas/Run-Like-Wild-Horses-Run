using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlideController : MonoBehaviour {
    public float speed;
 
    [SerializeField] Vector3 destination;
    public SceneTransitionManager transitionManager;
    private bool _doors = true;
    

    void Update () {
        
        if (destination != gameObject.transform.position) {
            
            IncrementPosition ();
        }
    }
 
    void IncrementPosition ()
    {
        
        float delta = speed * Time.deltaTime;
        Vector3 currentPosition = gameObject.transform.position;
        Vector3 nextPosition = Vector3.MoveTowards (currentPosition, destination, delta);


        gameObject.transform.position = nextPosition;

        if (gameObject.transform.position == destination && _doors)
        {
            _doors = false;
            StartCoroutine(DoorRoutine());
        }
    }

    IEnumerator DoorRoutine()
    {
        yield return new WaitForSeconds(2);
        GameObject[] doorArray = GameObject.FindGameObjectsWithTag ("Doors");
        foreach(GameObject g in doorArray)
        {
            g.SetActive (false);
        }
        yield return new WaitForSeconds(15);
        foreach(GameObject g in doorArray)
        {
            g.SetActive(true);

        }

        yield return new WaitForSeconds(2);
        transitionManager.GoToScene(3);

    }
}
