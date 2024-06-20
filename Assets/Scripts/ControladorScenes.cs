using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum TypeScene {SceneInstrucciones,ScenePrueba,SceneMenu,Scene1, Scene2, Scene3, Scene4, Scene5, Scene6, Scene7 };
public class ControladorScenes : MonoBehaviour
{
    [SerializeField] SceneConfiguration[] scenes;
    [SerializeField] PlayerPositionReferences playerPositionReferences;
    [SerializeField] bool xd;
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    public void InicialScenes()
    {
        SceneGlobalManager.Instance.LoadScene(scenes[0]);
        SceneGlobalManager.Instance.LoadScene(scenes[1]);
        SceneGlobalManager.Instance.LoadScene(scenes[2]);
    }

    public bool IsSceneLoaded(string sceneName)
    {
        Scene scene = SceneManager.GetSceneByName(sceneName);
        return scene.isLoaded;
    }

    public void positionUpdateType()
    {
        switch (playerPositionReferences.typeScenePlayer)
        {
            case TypeScene.Scene1:
                if (!IsSceneLoaded(scenes[0].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[0]);
                }
                if (!IsSceneLoaded(scenes[1].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[1]);
                }
                if (!IsSceneLoaded(scenes[2].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[2]);
                }

                //DesactiveScene
                if (IsSceneLoaded(scenes[3].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[3]);
                }
                if (IsSceneLoaded(scenes[4].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[4]);
                }
                if (IsSceneLoaded(scenes[5].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[5]);
                }
                if (IsSceneLoaded(scenes[6].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[6]);
                }

                break;
            case TypeScene.Scene2:
                if (!IsSceneLoaded(scenes[0].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[0]);
                }
                if (!IsSceneLoaded(scenes[1].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[1]);
                }
                if (!IsSceneLoaded(scenes[2].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[2]);
                }
                if (!IsSceneLoaded(scenes[3].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[3]);
                }

                //DesactiveScene
                if (IsSceneLoaded(scenes[4].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[4]);
                }
                if (IsSceneLoaded(scenes[5].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[5]);
                }
                if (IsSceneLoaded(scenes[6].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[6]);
                }
                break;
            case TypeScene.Scene3:

                if (!IsSceneLoaded(scenes[0].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[0]);
                }
                if (!IsSceneLoaded(scenes[1].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[1]);
                }
                if (!IsSceneLoaded(scenes[2].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[2]);
                }
                if (!IsSceneLoaded(scenes[3].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[3]);
                }
                if (!IsSceneLoaded(scenes[4].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[4]);
                }

                //DesactiveScene
                
                if (IsSceneLoaded(scenes[5].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[5]);
                }
                if (IsSceneLoaded(scenes[6].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[6]);
                }


                break;
            case TypeScene.Scene4:

                if (!IsSceneLoaded(scenes[1].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[1]);
                }
                if (!IsSceneLoaded(scenes[2].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[2]);
                }
                if (!IsSceneLoaded(scenes[3].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[3]);
                }
                if (!IsSceneLoaded(scenes[4].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[4]);
                }
                if (!IsSceneLoaded(scenes[5].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[5]);
                }

                //DesactiveScene

                if (IsSceneLoaded(scenes[0].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[0]);
                }
                if (IsSceneLoaded(scenes[6].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[6]);
                }

                break;
            case TypeScene.Scene5:

                if (!IsSceneLoaded(scenes[2].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[2]);
                }
                if (!IsSceneLoaded(scenes[3].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[3]);
                }
                if (!IsSceneLoaded(scenes[4].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[4]);
                }
                if (!IsSceneLoaded(scenes[5].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[5]);
                }
                if (!IsSceneLoaded(scenes[6].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[6]);
                }

                //DesactiveScene

                if (IsSceneLoaded(scenes[0].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[0]);
                }
                if (IsSceneLoaded(scenes[1].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[1]);
                }

                break;
            case TypeScene.Scene6:

                if (!IsSceneLoaded(scenes[3].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[3]);
                }
                if (!IsSceneLoaded(scenes[4].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[4]);
                }
                if (!IsSceneLoaded(scenes[5].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[5]);
                }
                if (!IsSceneLoaded(scenes[6].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[6]);
                }

                //DesactiveScene

                if (IsSceneLoaded(scenes[0].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[0]);
                }
                if (IsSceneLoaded(scenes[1].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[1]);
                }
                if (IsSceneLoaded(scenes[2].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[2]);
                }

                break;
            case TypeScene.Scene7:

                if (!IsSceneLoaded(scenes[4].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[4]);
                }
                if (!IsSceneLoaded(scenes[5].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[5]);
                }
                if (!IsSceneLoaded(scenes[6].SceneName))
                {
                    SceneGlobalManager.Instance.LoadScene(scenes[6]);
                }

                //DesactiveScene

                if (IsSceneLoaded(scenes[0].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[0]);
                }
                if (IsSceneLoaded(scenes[1].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[1]);
                }
                if (IsSceneLoaded(scenes[2].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[2]);
                }
                if (IsSceneLoaded(scenes[3].SceneName))
                {
                    SceneGlobalManager.Instance.UnloadScene(scenes[3]);
                }
                break;
        }
    }
}