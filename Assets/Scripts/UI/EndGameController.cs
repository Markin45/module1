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


    public void Open(int sound, string t)
    {

        WindowEndGame.SetActive(true);
        titleWindow.text = t;

        if (sound == 1) SoundControler.Instance.Go(SoundControler.Sound.Win);
        if (sound == 2) SoundControler.Instance.Go(SoundControler.Sound.Lose);
    }

    void GoScene_0()
    {
        SceneManager.LoadScene(0);
    }


}
