using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Compare : MonoBehaviour
{
    public ItemData itemData;
    public Image itemImage;  
    public GameObject ending03;
    public GameObject optionsPanel;

    public Sprite inventoryItem05;

    void Start()
    {
        CheckItemData();
    }

    public void CheckItemData()
    {
        if (itemData.selectedItemSprite == inventoryItem05)
        {   
            optionsPanel.SetActive(true); 
            ending03.SetActive(false); 
        }
        else
        {   
            optionsPanel.SetActive(false); 
            ending03.SetActive(true);  
        }
    }

    public void ReplayGame()
    { 
        itemData.ClearData();
        Destroy(gameObject); 
        SceneManager.LoadScene(1);
        GameIntroduction.instance.time = 30f;
    }



    void Update()
    {
        
    }
}
