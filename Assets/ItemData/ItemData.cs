using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "ItemData", menuName = "Game/ItemData")]
public class ItemData : ScriptableObject
{
    public Sprite selectedItemSprite;


    public void ClearData()
    {
        selectedItemSprite = null;
    }    

}