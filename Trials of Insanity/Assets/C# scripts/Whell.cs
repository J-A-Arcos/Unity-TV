using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Whell : Collectable
{
   public Sprite openWhell;
   public Sprite ropeWhell;
   public string sceneName;
   public scriptableRope Scriptablerope;

   protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
           GetComponent<SpriteRenderer>().sprite = openWhell;
           if(Scriptablerope.ropeObtained == true)
           {
                GetComponent<SpriteRenderer>().sprite = ropeWhell;
                if(Input.GetKeyDown(KeyCode.Y))
                {
                    SceneManager.LoadScene(sceneName);
                }
                else
                {
                    Debug.Log("Player doesnt want to proceed");
                }
           }
           else
           {
                Debug.Log("NO rope!");
           }
        }
    }
}
