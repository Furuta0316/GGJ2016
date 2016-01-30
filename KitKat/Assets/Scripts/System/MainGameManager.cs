// ----- ----- ----- ----- -----
//
// MainGameManager
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

[AddComponentMenu("MyScript/MainGameManager")]
public class MainGameManager : MonoBehaviour
{
	#region 変数

    [SerializeField, Tooltip("メインゲームかどうか")]
    bool isMainGame;

    private int stageNumber;

    [SerializeField, Tooltip("総ステージ数")]
    private int maxStageNumber;

    private SceneChanger sceneManager;

    #endregion


    #region プロパティ

    public bool IsMainGame
    {
        get { return isMainGame; }
    }



    #endregion



    #region メソッド

	// 初期化処理
    void Awake()
    {
        sceneManager = SceneChanger.Manager;
    }

    // 更新前処理
    void Start()
    {
        
    }

    // 更新処理
    void Update()
    {
    }

    void NextStage()
    {
        stageNumber++;
        sceneManager.SceneChange(SceneChanger.SceneName.MainGame);
        sceneManager.StageLoad(stageNumber);
    }

    void Retry()
    {
        sceneManager.StageLoad(stageNumber);
    }

	#endregion
}