using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverController : MonoBehaviour
{
    public Button btnPlay;
    public SO_Puntaje Score;
    public Text CurrentScore;
    public Text MaxScore;
    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(() => ReturnMenu());
        CurrentScore.text = "Score: " + Score.ScoreActual.ToString("000");
        MaxScore.text = "ScoreMax: " + Score.actualizarScore().ToString(); 
    }

    void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
