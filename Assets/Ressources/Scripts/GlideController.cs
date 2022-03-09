using System.Collections;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class GlideController : MonoBehaviour {
    public float speed;
 
    [SerializeField] Vector3 destination;
    [SerializeField] GameObject _player;
    [SerializeField] private GameObject _menu;
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
        
        Vector3 playerpos = _player.transform.position;
        if (playerpos.z < -6)
        {
            transitionManager.GoToScene(3);
        }
        else
        {
            _doors = true;
            destination = new Vector3(300, 0, 0);
            yield return new WaitForSeconds(11);
            _menu.SetActive(true);

        }

    }
}
