// ----- ----- ----- ----- -----
//
// EventSceneTimer
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

[AddComponentMenu("MyScript/EventSceneTimer")]
public class EventSceneTimer : MonoBehaviour
{
	#region 変数

    private SceneChanger manager;
    [SerializeField, Tooltip("このシーンの生存時間")]
    private float time;

    [SerializeField, Tooltip("次のシーンのネーム")]
    private SceneChanger.SceneName sceneName;

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
        StartCoroutine(SceneTimer());
    }

    // 更新処理
    void Update()
    {
        
    }

    IEnumerator SceneTimer()
    {
        yield return new WaitForSeconds(time);

        manager.SceneChange(sceneName);
    }

    public void Skip()
    {
        manager.SceneChange(sceneName);
    }
	#endregion
}