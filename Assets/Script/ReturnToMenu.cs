using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public void GoToMainMenu()
    {
        ResetGameState();
        SceneManager.LoadScene(0);
    }
    
    void ResetGameState()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj.scene.buildIndex == -1)
            {
                Destroy(obj);
            }
        }

        Time.timeScale = 1f;
    }
}
