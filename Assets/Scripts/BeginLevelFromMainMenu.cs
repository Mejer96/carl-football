using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BeginLevelFromMainMenu : MonoBehaviour
{
    public string sceneToLoad;

    public void beginLevel()
    {
        SceneManager.LoadScene(sceneToLoad);
       
    }
}
