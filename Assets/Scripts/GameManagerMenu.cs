using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour
{
    public void GoToSceneTest()
    {
        SceneManager.LoadScene("ScenePrueba");
    }
    public void GoToSceneGame2()
    {
        SceneManager.LoadScene("SceneGame2");
    }
    public void GoToSceneGame1()
    {
        SceneManager.LoadScene("SceneGame1");
    }
    public void QuitApplication()
    {
        Application.Quit();
    }
    public void SetObjectTrue(GameObject objectReferences)
    {
        objectReferences.SetActive(true);
    }
    public void SetObjectfalse(GameObject objectReferences)
    {
        objectReferences.SetActive(false);
    }
}
