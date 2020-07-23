using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class DangerCounter : MonoBehaviour
{
    // カウント用変数
    public float dangerCnt = 0f;
    public float dangerLimit = 10f;

    // クリックした時間保存用の変数
    double clickTimeAt;

    // ダブルクリックと判定するクリック間隔
    public double asDoubleClickTime = 0.25;

    //private float clickInterval = 0.75f;

    //public float currentTimeClick;
    //private float lastTimeClick;

    // Start is called before the first frame update
    void Start()
    {
        // 現在時間で初期化
        clickTimeAt = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
         
        //毎フレームごとにカウント減らす
        dangerCnt -= Time.deltaTime;

        //カウントはマイナスにはしない
        if (dangerCnt <= 0f)
        {
            dangerCnt = 0f;
        }

        if (Input.GetMouseButtonDown(0))
        {
            // キーを押した間隔を時間から算出
            double interval = Time.time - clickTimeAt;

            // 間隔がダブルクリック判定時間以下であれば
            if (interval < asDoubleClickTime)
            {
                dangerCnt++;
            }

            // クリックした時間を保存
            clickTimeAt = Time.time;

            //カウントが10になったらゲームオーバー
            if (dangerCnt >= 10)
            {
                SceneManager.LoadScene("GameOverScene");
            }

        }


        //カウントをTextコンポーネントへ 
        this.GetComponent<Text>().text = "保水力は" + dangerCnt + "%です";

        // もしdangerCntがdangerLimit以上になったら
        if (dangerCnt == dangerLimit)
        {
            // カウントを0に戻す
            //カウントをTextコンポーネントへ
            // this.GetComponent<Text>().text = "結果は" + result + "秒でした";
            SceneManager.LoadScene("ResultScene");
        }

        
    }

    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    currentTimeClick = eventData.clickTime;
    //    //Debug.Log(currentTimeClick);
    //    if (Mathf.Abs(currentTimeClick - lastTimeClick) <= clickInterval)
    //    {
    //        // カウントを増やす
    //        dangerCnt++;
    //    }
    //    lastTimeClick = currentTimeClick;
    //}



}