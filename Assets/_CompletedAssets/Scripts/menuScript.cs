using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;
    public Text highscoreText;

	// Use this for initialization
	void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        highscoreText.text = "Highscore : " + PlayerPrefs.GetInt("Highscore");
    }
	
    public void ExitPress ()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress ()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Level 01 5.x"); 
    }

    public void ExitGame()
    {
        Application.Quit();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
