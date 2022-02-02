using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;

    public void GoToScene(int sceneIndex)
    {
        Time.timeScale = 1;
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    public void Quit()
    {
        Application.Quit();
    }
    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        SceneManager.LoadScene(sceneIndex);


    }
 
}
