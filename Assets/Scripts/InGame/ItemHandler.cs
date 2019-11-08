﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHandler : MonoBehaviour
{
    public int idNum;
    public int amount;
    public ItemType type;
    public void OnCollection()
    {
        if (type == ItemType.Money)
        {
            Inventory.money += amount;
        }
        else if (type != ItemType.Weapon || type != ItemType.Apparel)
        {
            int found = 0;
            int addMe = 1;
            for (int i = 0; i < Inventory.inv.Count; i++)
            {
                if (idNum == Inventory.inv[i].ID)
                {
                    found = 1;
                    addMe = i;
                }
                if (found == 1)
                {
                    Inventory.inv[addMe].Amount += amount;
                }
                else
                {
                    Inventory.inv.Add(ItemData.CreateItem(idNum));
                }
            }
        }
        else
        {
            Inventory.inv.Add(ItemData.CreateItem(idNum));

        }
        Destroy(this.gameObject);
    }
}

