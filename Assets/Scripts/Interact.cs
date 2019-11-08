using UnityEngine;
using System.Collections;
//this script can be found in the Component section under the option Intro RPG/Player/Interact
[AddComponentMenu("Intro /PRG/RPG/Player/Interact")]
public class Interact : MonoBehaviour
{
    #region Variables



    #endregion
    #region Start
    //connect our player to the player variable via tag
    //connect our Camera to the mainCam variable via tag
    #endregion
    #region Update
    private void Update()
    {
        //if our interact key is pressed
        if (Input.GetButtonDown("Interact"))
        {
            //create a ray
            Ray Interact;

            //this ray is shooting out from the main cameras screen point center of screen
            Interact = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create hit info
            RaycastHit hitInfo;
            //if this physics raycast hits something within 10 units
            if (Physics.Raycast(Interact, out hitInfo, 10))
            {


                #region NPC tag
                //and that hits info is tagged NPC
                if (hitInfo.collider.CompareTag("NPC"))
                {

                    Dialogue dlg = hitInfo.transform.GetComponent<Dialogue>();
                    if (dlg != null)
                    {
                        dlg.showDlg = true;
                        Movement.canMove = false;
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                    }
                    //Debug that we hit a NPC
                    Debug.Log("NPC");
                }

                #endregion
                #region Item
                //and that hits info is tagged Item
                if (hitInfo.collider.CompareTag("Item"))
                {
                    //Debug that we hit an Item
                    Debug.Log("item");
                    ItemHandler handler = hitInfo.transform.GetComponent<ItemHandler>();
                    if (handler != null)
                    {
                        handler.OnCollection();
                    }
                }
                #endregion
            }
        }
    }


    #endregion
}






