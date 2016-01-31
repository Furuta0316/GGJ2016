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

	[Range(0, 1)]
	public float speed = 0.01f;
    private SceneChanger manager;

    #endregion


    #region プロパティ



    #endregion


    #region メソッド

	// 初期化処理
    void Awake()
    {
        manager = SceneChanger.Manager;
    }

    // 更新前処理
    void Start()
    {
        
    }

    // 更新処理
    void Update()
    {
        
    }

	public void SetSpeed(float _speed)
	{
		speed = _speed;
	}

    public void SceneChange(string sceneName)
    {
        manager.SceneChange(sceneName);
    }

    public void StageLoad(int stageNumber)
    {
        manager.StageLoad(stageNumber);
    }

	#endregion
}