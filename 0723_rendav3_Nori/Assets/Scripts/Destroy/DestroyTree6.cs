using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTree6 : TreeCount
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Cnt == 5)
        {
            Destroy(this.gameObject);
        }
    }
}
