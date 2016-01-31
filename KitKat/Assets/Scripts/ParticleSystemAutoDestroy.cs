// ----- ----- ----- ----- -----
//
// ParticleSystemAutoDestroy
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

[AddComponentMenu("MyScript/ParticleSystemAutoDestroy")]
public class ParticleSystemAutoDestroy : MonoBehaviour
{
	#region 変数

    [SerializeField, Tooltip("秒数")]
    float destroyToSecond;

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

    IEnumerator AutoDestroy()
    {
        yield return new WaitForSeconds(destroyToSecond);
        Destroy(gameObject);
    }
	#endregion
}