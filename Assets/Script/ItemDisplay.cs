using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Image itemImage;        
    public ItemData itemData;     

    void Start()
    {

        if (itemData.selectedItemSprite != null)
        {
            itemImage.sprite = itemData.selectedItemSprite;
        }
    }
}
