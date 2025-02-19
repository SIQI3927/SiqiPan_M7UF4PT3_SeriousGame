using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneCorridor: MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene(3); 
    }
}
