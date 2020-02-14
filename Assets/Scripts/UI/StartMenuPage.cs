using UnityEngine;
using UnityEngine.UI;

public class StartMenuPage : MonoBehaviour
{
    public Button[] PlayButtonS;
    public LoadingLogicPage LoadingLogic;

    private void Awake()
    {
        for (int i = 0; i < PlayButtonS.Length; i++)
        {
            int _i = i + 1; /////// не доконца еще разобрался с C# ну как я понял нужно в этом контексте создать переменую, иначе скрипт не работает
            PlayButtonS[i].onClick.AddListener(() => PlayGame(_i));
        }
    }

    private void PlayGame(int numLevel)
    {
        LoadingLogic.LoadScene(numLevel);
    }
}
