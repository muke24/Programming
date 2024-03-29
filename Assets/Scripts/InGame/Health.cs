﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LinearHealthBar
{
    [AddComponentMenu("Intro PRG/RPG/Player/Health - Linear")]
    public class Health : MonoBehaviour
    {
        [Header("Player Health")]
        // Public maxHealth
        public float maxHealth;
        // Public curHealth
        public float curHealth;
        [Header("UI Reference")]
        public Slider healthBar;
        public Image sliderFill;
        void Update()
        {
            healthBar.value = Mathf.Clamp01(curHealth / maxHealth);
        }
        void HealthManager()
        {
            if (curHealth <= 0 && sliderFill.enabled)
            {
                Debug.Log("Dead");
                sliderFill.enabled = false;
            }
            else if (!sliderFill.enabled && curHealth > 0)
            {
                Debug.Log("Revived");
                sliderFill.enabled = true;
            }
        }
    }
}
