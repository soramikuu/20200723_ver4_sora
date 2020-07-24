using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTree2 : TreeCount
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Cnt == 25)
        {
            Destroy(this.gameObject);
        }
    }
}
