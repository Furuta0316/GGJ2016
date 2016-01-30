using UnityEngine;
using System.Collections;

public class OpeningText : MonoBehaviour {
	
    [SerializeField]
    private float velocityY;// 文字の移動速度

    [SerializeField]
    private int pauseTimeFirstTime;// 最初の文字を止めておく時間

    private int pauseTime = 0;

    void Update () {
        if( pauseTime < pauseTimeFirstTime)
        {
            pauseTime++;
            return;
        }
        Vector3 pos = transform.position;
        pos.y += velocityY;
        transform.position = pos;

    }
}
