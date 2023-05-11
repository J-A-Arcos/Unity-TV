using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : Collectable
{
     public GameObject objectKnife;
    public bool knifeItem;
    //public scriptableRope Scriptablerope;
    
    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            knifeItem = true;
            objectKnife.SetActive(false);

            //Scriptablerope.ropeObtained = knifeItem;
        }
    }
}
