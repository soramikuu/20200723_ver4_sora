using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Result : TreeCount
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "結果は" + result + "秒でした";
    }

    // Update is called once per frame
    void Update()
    {

    }
}