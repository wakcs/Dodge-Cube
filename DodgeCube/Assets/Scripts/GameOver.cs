using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    bool show = false;
    float menuW = Screen.width / 2;
    float menuH = Screen.height / 2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}      

    void OnGUI()
    {
        if (show)
        {
            Rect windowRect = new Rect(menuW - 105, menuH - 50, 210, 100);
            GUI.Box(windowRect, "Game Over");
            if (GUI.Button(new Rect(menuW - 95, menuH - 25, 90, 50), "Retry"))
                Application.LoadLevel(Application.loadedLevel);
            if (GUI.Button(new Rect(menuW + 5, menuH - 25, 90, 50), "Quit"))
                Application.Quit();
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            show = true;
        }
    }
}
