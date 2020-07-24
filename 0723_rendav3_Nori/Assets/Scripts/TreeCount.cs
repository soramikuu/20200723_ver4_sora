using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TreeCount : MonoBehaviour
{
    // カウント用変数
    public int Cnt = 40;
    // 結果表示用変数
    public static int result;

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
            SceneManager.LoadScene("ResultScene");
        }
        
    }
}