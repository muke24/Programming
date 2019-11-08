using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int level;
    public new string name;
    public LinearHealthBar.Health health;
    public float curHp;
    public float maxHp;
    public CheckPoint checkPoint;
    public float x, y, z;

    public void SavePlayer()
    {
        curHp = health.curHealth;
        maxHp = health.maxHealth;
        x = checkPoint.curCheckPoint.x;
        y = checkPoint.curCheckPoint.y;
        z = checkPoint.curCheckPoint.z;
        Save.SavePlayerData(this);
    }
    public void LoadPlayer()
    {
        DataToSave data = Save.LoadPlayerData();
        level = data.level;
        name = data.playerName;
        curHp = data.curHp;
        maxHp = data.maxHp;
        health.curHealth = curHp;
        health.maxHealth = maxHp;
        x = data.x;
        y = data.y;
        z = data.z;
        this.transform.position = new Vector3(x, y, z);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SavePlayer();
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            LoadPlayer();
        }
    }

}
