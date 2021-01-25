﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemClickHandler : MonoBehaviour
{

    public Inventory.Inventory _Inventory;
    public InventorySlot Slot;

    public void OnItemClicked()
    {
        ItemDragHandler dragHandler = gameObject.transform.Find("Image").GetComponent<ItemDragHandler>();

        IInventoryItem item = dragHandler.Item;

        Debug.Log(item.Name);

        _Inventory.UseItem(item);

        item.OnUse();

        //Slot.InventoryPanelUI.SetActive(false);
        //Slot.GameIsPaused = false;
        //Time.timeScale = 1f;
    }

}
