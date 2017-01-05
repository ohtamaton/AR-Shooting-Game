using UnityEngine;
using System.Collections;

public class TitleScenenCtrl : MonoBehaviour {

    //ジャイロセンサの値を表示するプログラム
    void OnGUI()
    {
        //スタートからシーン遷移を行う
        if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2, Screen.width / 2, Screen.height / 5), "Start"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
        }
    }
}
