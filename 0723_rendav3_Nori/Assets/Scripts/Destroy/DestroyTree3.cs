﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTree3 : TreeCount
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Cnt == 20)
        {
            Destroy(this.gameObject);
        }
    }
}
