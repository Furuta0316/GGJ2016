// ----- ----- ----- ----- -----
//
// SceneManagerGetter
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

[AddComponentMenu("MyScript/SceneManagerGetter")]
public class SceneManagerGetter : MonoBehaviour
{
	#region 変数

    private SceneChanger manager;

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
        manager = GameObject.Find("SceneManager").GetComponent<SceneChanger>();
    }

    // 更新処理
    void Update()
    {
        
    }

    public void SceneChange(string sceneName)
    {
        manager.SceneChange(sceneName);
    }

	#endregion
}