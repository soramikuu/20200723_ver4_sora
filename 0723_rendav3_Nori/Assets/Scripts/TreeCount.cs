using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TreeCount : TimeCounter
{
    // カウント用変数
    public static int Cnt = 40;
    // 結果表示用変数
    public static int result;

    void Start()
    {
        Cnt = 40;
    }

    // フレーム毎に呼ばれる関数
    void Update()
    {
        // マウスがクリックされたら
        if (Input.GetMouseButtonDown(0))
        {
            // カウントを減らす
            Cnt--;
        }

        //カウントをTextコンポーネントへ 
        this.GetComponent<Text>().text = "残り" + Cnt + "本";

        if (Cnt == 0)
        {
            if (countup < 6)
            {
                SceneManager.LoadScene("ResultScene");
            }
            else if(countup < 10) {
                SceneManager.LoadScene("Result2Scene");
            }
            else
            {
                SceneManager.LoadScene("Result3Scene");
            }

        }
        
    }
}