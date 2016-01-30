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
        StageSelect,
        MainGame,
        Clear,
        GameOver,
        Ending,
    }

    private float      speed;
    private Color      col;
    private bool       isLock = false;
    private Image      image;
    private GameObject childObject;

    #endregion


    #region プロパティ



    #endregion


    #region メソッド

	// 初期化処理
    void Awake()
    {
        childObject = transform.GetChild(0).gameObject;
        image       = childObject.GetComponent<Image>();
        name        = "temp";

        if(GameObject.Find("SceneManager") != null)
        {
            Destroy(gameObject);
            return;
        }

        name = "SceneManager";
        DontDestroyOnLoad(gameObject);
    }

    // 更新前処理
    void Start() { }

    // 更新処理
    void Update() { }

    public void SceneChange(SceneName sceneName, float fadeSpeed = 0.01f)
    {
        SceneChange(sceneName, new Color(0, 0, 0, 0), fadeSpeed);
    }

    public void SceneChange(SceneName sceneName, Color fadeColor, float fadeSpeed = 0.01f)
    {
        if(isLock == false)
        {
            speed  = fadeSpeed;
            col    = fadeColor;
            StartCoroutine(FadeIn(sceneName, fadeSpeed, fadeColor));
        }
    }

    IEnumerator FadeIn(SceneName sceneName, float fadeSpeed, Color fadeColor)
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

    void Change(SceneName sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString(), LoadSceneMode.Single);

        StartCoroutine(FadeOut(speed, col));
    }
	#endregion
}