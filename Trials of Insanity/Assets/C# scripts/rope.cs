using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : Collectable
{
    public GameObject objectRope;
    public bool ropeItem;
    
    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            ropeItem = true;
            objectRope.SetActive(false);
        }
    }
}
