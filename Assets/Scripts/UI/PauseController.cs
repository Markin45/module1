using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public Button ButtonOnPause;

    public Button ButtonGoOn;
    public Button ButtonAgain;
    public Button ButtonGoScene_0;

    public GameObject WindowPause;

    public static bool onPause = false;

    void Awake()
    {
        WindowPause.SetActive(false);
        onPause = false;

        ButtonOnPause.onClick.AddListener(Open);
        ButtonGoOn.onClick.AddListener(Close);
        ButtonAgain.onClick.AddListener(UpdateScene);
        ButtonGoScene_0.onClick.AddListener(GoScene_0);
    }


    void Open()
    {
        WindowPause.SetActive(true);
        onPause = true;
    }

    void Close()
    {
        WindowPause.SetActive(false);
        onPause = false;
    }

    void UpdateScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void GoScene_0()
    {
        SceneManager.LoadScene(0);
    }


}
