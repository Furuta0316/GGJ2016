// ----- ----- ----- ----- -----
//
// GameSceneChange
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

[AddComponentMenu("MyScript/GameSceneChange")]
public class GameSceneChange : MonoBehaviour
{
	#region 変数


    private GameObject sceneManager;

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
        
    }

    //ステージという概念がなくなったらこっちをお使いください
    void GameEnd(bool isGameClear)
    {
        GameEnd(isGameClear, 0);
    }

    //ステージ有り用
    void GameEnd(bool isGameClear, int stageNumber)
    {
        if(isGameClear)
        {
            //ゲームクリア
            
        }
        else
        {
            //ゲームオーバー
            
        }
    }
	#endregion
}