using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField] GameObject _winScreen;
    [SerializeField] GameObject _konti;
    private bool _triggered = false;
    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player") && !_triggered)
        {
            _triggered = true;
            _winScreen.SetActive(true);
            _konti.SetActive(false);
            
        }
                
                
    }

    public void DisableWinScreen(GameObject screen)
    {
        _winScreen.SetActive(false);
    }
}
