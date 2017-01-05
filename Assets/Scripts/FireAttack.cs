/**
 * FireAttack.cs
 * 
 * Fireの移動処理
 *
 * @author ys.ohta
 * @version 1.0
 * @date 2016/08/XX
 */
using UnityEngine;
using System.Collections;

public class FireAttack : MonoBehaviour {
//===========================================================
// 変数宣言
//===========================================================

    //---------------------------------------------------
    // public
    //---------------------------------------------------

    //None.

    //---------------------------------------------------
    // private
    //---------------------------------------------------

    //Fireボタンの速度と方向
    private Vector3 velocity;

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
     * velocityの初期化
     * </summary>
     * @param
     * @return
     **/
    void Start ()
    {
        velocity = Vector3.Scale(transform.forward.normalized, new Vector3(0.5f, 0.5f, 0.5f));
    }

    /**
     * <summary>
     * Fireの移動処理
     * </summary>
     * @param
     * @return
     **/
    void Update () {

        //Fireオブジェクトを前に進める
        transform.position += velocity;
        
        //Fireが何にも当たらずに一定距離進んだら削除
        if (transform.position.z > 300)
        {
            Destroy(gameObject);
        }
	}

    /**
     * <summary>
     * Fireが敵キャラと衝突した場合両方とも削除
     * </summary>
     * @param
     * @return
     **/
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("GameObject"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
           
    }
}
