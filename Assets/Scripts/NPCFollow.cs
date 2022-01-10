using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class NPCFollow : MonoBehaviour
{
    //Transform that NPC has to follow
    public Transform transformToFollow;

    public float delay = 15f;
    //NavMesh Agent variable
    NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayAgent(delay));
        
    }

    // Update is called once per frame
    void Update()
    {
        //Follow the player
        if (_agent == null) return;
        _agent.destination = transformToFollow.position;
    }

    IEnumerator DelayAgent(float delay)
    {
        yield return new WaitForSeconds(delay);
        _agent = GetComponent<NavMeshAgent>();
    }
}
