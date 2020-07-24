using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTree7 : TreeCount
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Cnt == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
