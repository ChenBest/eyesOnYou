﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public int size = 1;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id, string title, string description, Sprite icon,
        Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Inventories/" + title);
        this.stats = stats;
    }

    public Item(Inventory inventory)
    {
        this.id = inventory.id;
        this.title = inventory.title;
        this.description = inventory.description;
        this.icon = Resources.Load<Sprite>("Sprites/Inventories/" + inventory.title);
        this.stats = inventory.stats;

    }

}
