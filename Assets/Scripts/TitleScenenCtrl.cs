/**
 * TitleSceneCtrl.cs
 * 
 * Game用のGUI
 *
 * @author ys.ohta
 * @version 1.0
 * @date 2016/08/XX
 */
using UnityEngine;
using System.Collections;

/**
 * TitleSceneCtrl
 */
public class TitleScenenCtrl : MonoBehaviour {
    //===========================================================
    // 関数宣言
    //===========================================================

    //---------------------------------------------------
    // public
    //---------------------------------------------------

    //None. 

    //---------------------------------------------------
    // private
    //---------------------------------------------------

    //None. 

    //---------------------------------------------------
    // other
    //---------------------------------------------------

    /**
     * <summary>
     * タイトル用のGUI定義
     * </summary>
     * @param
     * @return
     **/
    void OnGUI()
    {
        //スタートからシーン遷移を行う
        if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2, Screen.width / 2, Screen.height / 5), "Start"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
        }
    }
}
