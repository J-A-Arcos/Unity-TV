using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Whell : Collidable
{
   public Sprite openWhell;
   public Sprite ropeWhell;
   public string sceneName;

   protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
           GetComponent<SpriteRenderer>().sprite = openWhell;
           SceneManager.LoadScene(sceneName);
        }
    }
}
