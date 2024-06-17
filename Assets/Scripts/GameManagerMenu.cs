using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour
{
    [Header("Scenes SO")]
    [SerializeField] private SceneConfiguration scenePrueba;
    [SerializeField] private SceneConfiguration sceneSelection;

    private void Start()
    {
        SceneGlobalManager.OnStartProgress?.Invoke();
    }
    public void GoToSceneTest()
    {
        SceneGlobalManager.OnFinishProgress?.Invoke();
        SceneGlobalManager.Instance.LoadScene(scenePrueba);
    }
    public void GoToSceneInstrucciones()
    {
        SceneGlobalManager.OnFinishProgress?.Invoke();
        SceneGlobalManager.Instance.LoadScene(sceneSelection);
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
