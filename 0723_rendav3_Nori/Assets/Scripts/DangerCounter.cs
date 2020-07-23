using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DangerCounter : MonoBehaviour
{
    // カウント用変数
    public int dangerCnt = 0;
    public int dangerLimit = 20;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // マウスがクリックされたら
        if (Input.GetMouseButtonDown(0))
        {
            // カウントを減らす
            dangerCnt++;
        }

        //カウントをTextコンポーネントへ 
        this.GetComponent<Text>().text = "保水力は" + dangerCnt + "%です";

        // もしdangerCntが20以上になったら
        if (dangerCnt == dangerLimit)
        {
            // カウントを0に戻す
            //カウントをTextコンポーネントへ
            // this.GetComponent<Text>().text = "結果は" + result + "秒でした";
            SceneManager.LoadScene("ResultScene");
        }
    }
}