using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class OptionsPage : MonoBehaviour
{
    public ItemData itemData; 
    public GameObject endingPanel01, endingPanel02;
    public GameObject optionPanel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SelectElevator()
    {
        endingPanel01.SetActive(true);
        optionPanel.SetActive(false);
    }

    public void SelecStairs()
    {
        if (GameIntroduction.instance != null && GameIntroduction.instance.time >= GameIntroduction.instance.initialTime - 10)
        {
          if (itemData != null)
            {
                itemData.selectedItemSprite = null;
                //itemData.ClearData(); 
            }
            Destroy(gameObject); 
            SceneManager.LoadScene(4);
        }
        else
        {
            endingPanel02.SetActive(true);
            optionPanel.SetActive(false);
        }

    }

}
