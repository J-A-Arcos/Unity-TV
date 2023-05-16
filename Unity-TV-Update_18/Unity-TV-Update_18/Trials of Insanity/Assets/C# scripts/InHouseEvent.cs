using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;
using UnityEngine;

public class InHouseEvent : MonoBehaviour
{
    public knife Knife;
    public scriptableRope Scriptablerope2;
    public string sceneName;
    public Light2D light;
    public int lightIntensity = 0;
        
    private void Update()
    {
        if(Knife.knifeItem == true && Scriptablerope2.ropeObtained == true)
        {
            light.intensity = lightIntensity;
            for(int i = 15; i < 30; i++)
            {
                if(i * Time.deltaTime >= 0.0015)
                {
                    SceneManager.LoadScene(sceneName);
                }
                else
                {
                    Debug.Log(i * Time.deltaTime);
                }
            }
        }
    }
}