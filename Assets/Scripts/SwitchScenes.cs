using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void ImageTrackingScene()
    {
        SceneManager.LoadScene("ImageTracking");
    }

    public void PlaneTrackingScene()
    {
        SceneManager.LoadScene("PlaneTracking");
    }
    
    public void ARTrackingScene()
    {
        SceneManager.LoadScene("ARTracking");
    }
}
