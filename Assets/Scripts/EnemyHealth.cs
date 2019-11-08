﻿
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public float maxHp, curHp;
    public Canvas myCanvas;
    public Slider mySlider;
    void Start()
    {
        myCanvas = this.transform.Find("Canvas").GetComponent<Canvas>();
        mySlider = myCanvas.transform.Find("Slider").GetComponent<Slider>();
    }

    
    void Update()
    {
        mySlider.value = Mathf.Clamp01(curHp / maxHp);
        myCanvas.transform.LookAt(Camera.main.transform);
    }
}
