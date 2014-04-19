using UnityEngine;
using System.Collections;
using System.Threading;

public class GUIOverlay : MonoBehaviour {
    float fScore = 0;
    bool showMenu = true;
    float menuW = Screen.width / 2;
    float menuH = Screen.height / 2;
    string playResume = "Play";

    void Start()
    {
        Time.timeScale = 0;
    }

    void OnGUI()
    {
        Rect windowRect = new Rect(menuW - 105, menuH - 50, 210, 100);

        if (showMenu)
        {
            GUI.Box(windowRect, "Dodge Cube");
            if (GUI.Button(new Rect(menuW - 95, menuH - 25, 90, 50), playResume))
            {
                playResume = "Resume";
                Time.timeScale = 1;
                showMenu = false;
            }
            if (GUI.Button(new Rect(menuW + 5, menuH - 25, 90, 50), "Quit"))
                Application.Quit();
        }

        int iScore = (int)fScore;
        GUI.Box(new Rect(menuW - 50, 20, 100, 40), "");
        GUI.Label(new Rect(menuW - 40, 30, 80, 20), "Score: " + iScore);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            showMenu = !showMenu;
            if (showMenu)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }

        fScore += Time.deltaTime;
    }
}
