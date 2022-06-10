using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class UIManager : MonoBehaviour
{
    public Button StartButton;
    public Button ExitButton;
    public TextMeshProUGUI HighScoreText;
    [SerializeField] TextMeshProUGUI playerName;

    private void Start()
    {
        DataManager.LoadInfo();
        HighScoreText.text = "Current High Score: " + DataManager.HighName + " " + DataManager.HighScore;
        StartButton.onClick.AddListener(StartGame);
        ExitButton.onClick.AddListener(QuitGame);

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        DataManager.Name = playerName.text;

    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
Application.Quit();
#endif
    }
}