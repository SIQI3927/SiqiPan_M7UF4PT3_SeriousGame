using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class ItemSelectionManager : MonoBehaviour
{
    public GameObject[] mainButtons;
    public GameObject[] optionPages; 
    public GameObject buttonItem;
    public Image itemImage;
    public Button pickButton;
    public Button cancelButton;

    public Sprite[] itemSprites;

    public ItemData itemData;


    void Start()
    {
        foreach (var page in optionPages)
        {
            page.SetActive(false);
        }
        
        if (itemData.selectedItemSprite != null)
        {
            itemImage.sprite = itemData.selectedItemSprite;

        }
        
    }

    public void ShowOptionPage(int index)
    {
        foreach (var page in optionPages)
        {
            page.SetActive(false);
        }

        buttonItem.SetActive(false);
        optionPages[index].SetActive(true);
    }


    public void PickItem(int index)
    {   
        itemData.selectedItemSprite = itemSprites[index];
        itemImage.sprite = itemSprites[index];  
        CloseOptionPage();
        buttonItem.SetActive(true);
    }


    public void CancelSelection()
    {
        Debug.Log("Cancelled selection.");
        CloseOptionPage();
        buttonItem.SetActive(true);
    }


    void CloseOptionPage()
    {
        foreach (var page in optionPages)
        {
            page.SetActive(false);
        }
    }

}