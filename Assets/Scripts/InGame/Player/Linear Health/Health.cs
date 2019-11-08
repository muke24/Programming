using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Allow us to interact with UI elements
using UnityEngine.UI;
//this script can be found in the Component section under the option Intro PRG/Player/Health

public class Health : MonoBehaviour
{
    [Header("Reference for Health")]
    //public maxHealth
    public float maxHealth;
    //public curHealth
    public float curHealth;
    // Players delay health drop
    public float delayHealth;
    [Header("Delay Drop Speed")]
    // Speed that delay health drops at
    public float speed;
    [Header("Reference for UI elements")]
    // Referece to Slider
    public Slider healthSlider;
    // Reference to fill
    public Image healthFill;
    // Reference to Delay Slider
    public Slider delaySlider;
    // Reference to Delay Slider


    [Header("Heart Slots")]
    //Canvas Image heartSlots array
    public Image[] heartSlots = new Image[3];
    //Sprite hearts array
    public Sprite[] hearts = new Sprite[5];
    //private percent healthPerSection
    private float healthPerSection;
    #region Start
           // Run UpdateHearts
           void Start()
           {
                UpdateHearts();

           }
    #endregion
	#region Update 
        public void Update()
        {
            //index variable starting at 0 for slot checks
            int i = 0;
            //foreach Image slot in heartSlots
            foreach (Image slot in heartSlots)
            {
                //if curHealth is greater or equal to full for this slot amount
                if (curHealth >= (healthPerSection * 4)+ (healthPerSection * 4)*i)
                {
                    //Set heart to 4/4
                    heartSlots[i].sprite = hearts[0];
                }
                
                //else if curHealth is greater or equal to 3/4 for this slot amount
                else if (curHealth >= (healthPerSection * 3) + (healthPerSection * 4) * 1)
                {
                    //Set Heart to 3/4
                    heartSlots[i].sprite = hearts[1];
                }
                
                //else if curHealth is greater or equal to 2/4 for this slot amount
                else if (curHealth >= (healthPerSection * 2) + (healthPerSection * 4) * 2)
                {
                    //Set Heart to 2/4
                    heartSlots[i].sprite = hearts[2];
                }

                //else if curHealth is greater or equal to 1/4 for this slot amount
                else if (curHealth >= (healthPerSection * 1) + (healthPerSection * 4) * 3)
                {
                    //Set Heart to 1/4
                    heartSlots[i].sprite = hearts[3];
                }
                //else
                //we are empty
            }
            //after checking this slot increase slot index
            i++;
        }
        

	#endregion
    #region UpdateHearts
    void UpdateHearts()
    {
        //calculate the health points per heart section
        healthPerSection = maxHealth / (heartSlots.Length * 4);
    }
    #endregion
}
