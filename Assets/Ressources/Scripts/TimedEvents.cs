using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedEvents : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        StartCoroutine(EventsInScene());
    }
 
    IEnumerator EventsInScene()
    {
        Debug.Log("starting coroutine");
        yield return new WaitForSeconds(5);
        Debug.Log(5);
        yield return new WaitForSeconds(5);
        Debug.Log(10);
        //Your Function You Want to Call
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
