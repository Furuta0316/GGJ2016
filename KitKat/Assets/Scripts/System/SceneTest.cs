// ----- ----- ----- ----- -----
//
// SceneTest
//
// 作成日：
// 作成者：
//
// <概要>
//
//
// ----- ----- ----- ----- -----

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("MyScript/SceneTest")]
public class SceneTest : MonoBehaviour
{
	#region 変数

    //[SerializeField, Tooltip("説明文")]

    #endregion


    #region プロパティ



    #endregion


    #region メソッド

	// 初期化処理
    void Awake()
    {

    }

    // 更新前処理
    void Start()
    {
        
    }

    // 更新処理
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    GameObject.Find("SceneManager").
        //        GetComponent<SceneChanger>().SceneChange(SceneChanger.SceneName.scene3, new Color(1, 0, 0, 1), 0.01f);
        //}
    }
	#endregion
}