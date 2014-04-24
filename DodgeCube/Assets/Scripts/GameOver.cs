using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    bool show = false;
    float menuW = Screen.width / 2;
    float menuH = Screen.height / 2;
    int iScore;
    int topScore;
    float fScore;
    string overWin = "Game Over";
	// Use this for initialization
	void Start () {
        topScore = PlayerPrefs.GetInt("HighScore");
	}
	
	// Update is called once per frame
	void Update () {
        fScore += Time.deltaTime;
        if(iScore >= topScore)
            topScore = iScore;

        if (iScore == 9999)
        {
            Time.timeScale = 0;
            overWin = "Game Won!";
            show = true;
        }
	}      

    void OnGUI()
    {
        if (show)
        {
            Rect windowRect = new Rect(menuW - 105, menuH - 50, 210, 100);
            GUI.Box(windowRect, overWin);
            if (GUI.Button(new Rect(menuW - 95, menuH - 25, 90, 50), "Retry"))
            {
                
                Application.LoadLevel(Application.loadedLevel);
            }
            if (GUI.Button(new Rect(menuW + 5, menuH - 25, 90, 50), "Quit"))
                Application.Quit();
        }
        iScore = (int)fScore;
        GUI.Box(new Rect(menuW - 75, 20, 150, 50), "");
        GUI.Label(new Rect(menuW - 70, 25, 100, 25), "Score: " + iScore);
        GUI.Label(new Rect(menuW - 70, 45, 100, 25), "Highscore: " + topScore);
        if (GUI.Button(new Rect(menuW + 25, 20, 50, 50), "Reset\nScore"))
        {
            PlayerPrefs.DeleteKey("HighScore");
            topScore = PlayerPrefs.GetInt("HighScore");
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            show = true;
            PlayerPrefs.SetInt("HighScore", topScore);
        }
    }
}
