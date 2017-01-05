/**
 * GameGUI.cs
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
 * GameGUI
 */
public class GameGUI : MonoBehaviour
{
//===========================================================
// 変数宣言
//===========================================================

    //---------------------------------------------------
    // public
    //---------------------------------------------------

    //Fireオブジェクト
    public GameObject fire;

    //---------------------------------------------------
    // private
    //---------------------------------------------------  

    //playerの位置を取得するためにCameraを設定
    [SerializeField] private GameObject player;

    //Fireボタンが押されたかどうか
    private bool down = false;

//===========================================================
// 関数宣言
//===========================================================

    //---------------------------------------------------
    // public
    //---------------------------------------------------

    /**
     * <summary>
     * downのgetter
     * </summary>
     * @param
     * @return
     **/
    public bool getDown()
    {
        return down;
    }

    /**
     * <summary>
     * downのsetter
     * </summary>
     * @param
     * @return
     **/
    public void setDown(bool b)
    {
        down = b;
    }

    //---------------------------------------------------
    // private
    //---------------------------------------------------

    //None. 

    //---------------------------------------------------
    // other
    //---------------------------------------------------

    /**
     * <summary>
     * ゲーム用のGUIを定義
     * </summary>
     * @param
     * @return
     **/
    void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width - 150, Screen.height - 150, 150, 150), "fire"))
        {
            //Fireボタンを押されたらplayerの前にFireオブジェクトを生成する
            down = true;
            Vector3 pos = new Vector3(player.transform.position.x,
                player.transform.position.y + 1, player.transform.position.z);
            Instantiate(fire, pos, player.transform.rotation);
        }
    }

}
