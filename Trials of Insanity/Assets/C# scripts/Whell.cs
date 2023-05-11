using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Whell : Collectable
{
   public Sprite openWhell;
   public Sprite ropeWhell;
   public string sceneName;
   //public rope Rope;
   public scriptableRope Scriptablerope;

   protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
           GetComponent<SpriteRenderer>().sprite = openWhell;
           //SceneManager.LoadScene(sceneName);
           if(Scriptablerope.ropeObtained == true)
           {
                GetComponent<SpriteRenderer>().sprite = ropeWhell;
           }
           else
           {
                Debug.Log("NO rope!");
           }
        }
    }
}
