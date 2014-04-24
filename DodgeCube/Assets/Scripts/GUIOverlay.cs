using UnityEngine;
using System.Collections;
using System.Threading;

public class GUIOverlay : MonoBehaviour {
    bool showMenu = true;
    float menuW = Screen.width / 2;
    float menuH = Screen.height / 2;
    string playResume = "Play";
    string txtDiff = "Easy";
    int diff = 1;

    void Start()
    {
        Time.timeScale = 0;
        diff = PlayerPrefs.GetInt("Difficulty");
        txtDiff = PlayerPrefs.GetString("txtDifficulty");
    }

    void OnGUI()
    {
        Rect windowRect = new Rect(menuW - 105, menuH - 50, 210, 200);

        if (showMenu)
        {
            GUI.Box(windowRect, "Dodge Cube");
            if (GUI.Button(new Rect(menuW - 95, menuH - 25, 90, 50), playResume))
            {
                playResume = "Resume";
                Time.timeScale = diff;
                showMenu = false;
            }
            if (GUI.Button(new Rect(menuW + 5, menuH - 25, 90, 50), "Quit"))
                Application.Quit();

            GUI.Label(new Rect(menuW - 30, menuH + 30, 60, 20), "Difficulty:");
            if(GUI.Button(new Rect(menuW - 45, menuH + 55, 90, 50), txtDiff))
            {
                if (diff < 4)
                    diff++;
                else
                    diff = 1;

                txtDiff = ChangeDifficulty(diff);
                PlayerPrefs.SetInt("Difficulty", diff);
                PlayerPrefs.SetString("txtDifficulty", txtDiff);
            }
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            showMenu = !showMenu;
            if (showMenu)
                Time.timeScale = 0;
            else
                Time.timeScale = diff;
        }
    }

    string ChangeDifficulty(int number)
    {
        string text = "";
        switch (number)
        {
            case 1:
                text = "Easy";
                break;
            case 2:
                text = "Normal";
                break;
            case 3:
                text = "Hard";
                break;
            case 4:
                text = "Extreme";
                break;
            default:
                break;
        }
        return text;
    }
}
