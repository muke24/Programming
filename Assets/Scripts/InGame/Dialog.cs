using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public bool showDlg;
    public Vector2 scr;
    public string[] dlgText;
    public int index, optionsIndex;

    void OnGUI()
    {
        if (showDlg)
        {
            if (scr.x != Screen.width / 16 || scr.y != Screen.height / 9)
            {
                scr.x = Screen.width / 16;
                scr.y = Screen.width / 9;
            }
            GUI.Box(new Rect(0, 6 * scr.y, Screen.width, 3 * scr.y), dlgText[index]);
            if (!(index > dlgText.Length))
            {
                if (GUI.Button(new Rect(scr.x * 15, scr.y * 8.5f, scr.x, scr.y * 0.5f), "Next"))
                {
                    index++;
                }

            }
            else if (index == optionsIndex)
            {
                if (!(index > dlgText.Length))
                {
                    if (GUI.Button(new Rect(scr.x * 13, scr.y * 8.5f, scr.x, 0.5f * scr.y), "Accept"))
                    {
                        index++;
                    }
                }
                if (!(index > dlgText.Length))
                {
                    if (GUI.Button(new Rect(scr.x * 14, scr.y * 8.5f, scr.x, scr.y * 0.5f), "Decline"))
                    {
                        index = dlgText.Length - 1;
                    }
                }
                else
                {
                    if (GUI.Button(new Rect(scr.x * 15, scr.y * 8.5f, scr.x, scr.y * 0.5f), "Bye."))
                    {
                        index = 0;
                        showDlg = false;
                        Movement.canMove = true;
                        Cursor.lockState = CursorLockMode.Locked;
                        Cursor.visible = false;
                        //enable camera and player movement
                    }

                }
            }

        }
    }
}
