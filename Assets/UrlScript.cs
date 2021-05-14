using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlScript : MonoBehaviour
{
    public string Url;
    static int loadCount = 0;
    // private AdmobAd MyAd;
    public void Open(){
        Application.OpenURL(Url);
        loadCount++;
        if(loadCount % 3 == 0)
        {
            AdmobAd.instance.ShowFullScreenAd();
        }
    }

    public void QuitApp(){
        Application.Quit();
        Debug.Log("quit");
    }
}
