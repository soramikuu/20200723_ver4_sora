﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class DangerCounterBar : MonoBehaviour
{
    // カウント用変数
    public float dangerCnt = 0f;
    public float dangerLimit = 10f;

    // クリックした時間保存用の変数
    double clickTimeAt;

    // ダブルクリックと判定するクリック間隔
    public double asDoubleClickTime = 0.25;

    //Slider
    public Slider slider;

    void Start()
    {
        // 現在時間で初期化
        clickTimeAt = Time.time;

        //Sliderを満タンに
        slider.value = 1;
    }

    void Update()
    {

        //毎フレームごとにカウント減らす
        dangerCnt -= Time.deltaTime * 3;

        slider.value = (float)dangerCnt / (float)dangerLimit;

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

                slider.value = (float)dangerCnt / (float)dangerLimit;
            }

            // クリックした時間を保存
            clickTimeAt = Time.time;

            

            //カウントが10になったらゲームオーバー
            if (dangerCnt >= 10)
            {
                SceneManager.LoadScene("GameOverScene");
            }

        }

        // もしdangerCntがdangerLimit以上になったら
        if (dangerCnt == dangerLimit)
        {
            // カウントを0に戻す
            //カウントをTextコンポーネントへ

            SceneManager.LoadScene("ResultScene");
        }


    }

}