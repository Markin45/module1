using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour
{

    public Button ButtonGoScene_0;
    public Text titleWindow;

    public GameObject WindowEndGame;

    void Awake()
    {
        WindowEndGame.SetActive(false);
        ButtonGoScene_0.onClick.AddListener(GoScene_0);
    }


    public void Open(string t)
    {
        WindowEndGame.SetActive(true);
        titleWindow.text = t;
    }

    void GoScene_0()
    {
        SceneManager.LoadScene(0);
    }


}
