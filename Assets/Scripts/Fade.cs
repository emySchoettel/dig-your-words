using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{

    public Image unPanel; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeIn()
    {
        unPanel.CrossFadeAlpha(1.0f, 3.0f, true);
    }

    public void FadeOut()
    {
        unPanel.CrossFadeAlpha(0.0f, 3.0f, true);
    }
}
