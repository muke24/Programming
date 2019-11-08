using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataToSave
{
    public int level;
    public string playerName;
    public float maxHp, curHp;
    public float x, y, z;

    public DataToSave(PlayerManager player)
    {
        level = player.level;
        playerName = player.name;
        curHp = player.curHp;
        maxHp = player.maxHp;
        x = player.x;
        y = player.y;
        z = player.z;
    }
}
