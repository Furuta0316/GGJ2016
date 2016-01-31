// ----- ----- ----- ----- -----
//
// SceneManager
//
// 作成日：
// 作成者：
//
// <概要>
//
//
// ----- ----- ----- ----- -----

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

[RequireComponent(typeof(Canvas))]
[AddComponentMenu("SceneManager/SceneChanger")]
public class SceneChanger : MonoBehaviour
{
	#region 変数

    public enum SceneName
    {
        Opening,
        Title,
        Tutorial,
        StageSelect,
        Stage1_example,
        Clear,
        GameOver,
        Ending,
        Exit,
    }

    private float      speed;
    private Color      col;
    private bool       isLock = false;
    private Image      image;
    private GameObject childObject;

    #endregion


    #region プロパティ

    public static SceneChanger Manager
    {
        get
        {
            GameObject manager = GameObject.Find("SceneManager");
            if(manager != null)
            {
                return manager.GetComponent<SceneChanger>();
            }

            GameObject prefab = (GameObject)Resources.Load ("Prefabs/System/SceneManager");

            return Instantiate(prefab).GetComponent<SceneChanger>();
        }
    }

    #endregion


    #region メソッド

	// 初期化処理
    void Awake()
    {
        childObject = transform.GetChild(0).gameObject;
        image       = childObject.GetComponent<Image>();
        DontDestroyOnLoad(gameObject);
    }

    // 更新前処理
    void Start() { }

    // 更新処理
    void Update() { }

    public void AddScene(SceneName sceneName)
    {
		SceneManager.LoadScene(sceneName.ToString(), LoadSceneMode.Additive);
    }

    public void SceneChange(string sceneName)
    {
        SceneChange((SceneName)Enum.Parse(typeof(SceneName), sceneName));
    }

    public void SceneChange(SceneName sceneName, float fadeSpeed = 0.05f)
    {
        SceneChange(sceneName, new Color(0, 0, 0, 0), fadeSpeed);
    }

    public void SceneChange(SceneName sceneName, Color fadeColor, float fadeSpeed = 0.05f)
    {
        if(isLock == false)
        {
            speed  = fadeSpeed;
            col    = fadeColor;
            StartCoroutine(FadeIn(sceneName.ToString(), fadeSpeed, fadeColor));
        }
    }

    IEnumerator FadeIn(string sceneName, float fadeSpeed, Color fadeColor)
    {
        isLock = true;

        for(float i = 0.0f; i <= 1.0f; i += fadeSpeed)
        {
            fadeColor.a = i;
            image.color = fadeColor;

            yield return null;
        }

        col = fadeColor;
        Change(sceneName);
    }

    IEnumerator FadeOut(float fadeSpeed, Color fadeColor)
    {
        for(float i = 1.0f; i >= 0.0f; i -= fadeSpeed)
        {
            fadeColor.a = i;
            image.color = fadeColor;

            yield return null;
        }

        isLock = false;
        col    = new Color(0, 0, 0, 0);
        speed  = 0;
    }

    void Change(string sceneName)
    {
        if(sceneName == "Exit")
        {
            Application.Quit();
        }

        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);

        StartCoroutine(FadeOut(speed, col));
    }

    public void StageLoad(int stageNumber)
    {
        speed = 0.05f;
        StartCoroutine(FadeIn("Stage" + stageNumber, 0.05f, new Color(0, 0, 0, 0)));
    }

    IEnumerator SyncSceneChange(string name)
    {
        while(true)
        {
            //後で
            yield break;
        }
    }

    public void StageRetry()
    {
        Scene scene = SceneManager.GetActiveScene();
        
        speed = 0.05f;
        StartCoroutine(FadeIn( scene.name, 0.05f, new Color(0, 0, 0, 0)));
    }
	#endregion
}