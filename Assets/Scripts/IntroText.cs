using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroText : MonoBehaviour
{
    // Start is called before the first frame update

    public Text unText;

    public GameObject uneimage; 

    CanvasGroup canvasGroup; 

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        LeanTween.alpha(uneimage.GetComponent<RectTransform>(), 0.0f, 0.0f);
        uneimage.SetActive(false);
        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);
        unText.fontSize = 35;
        unText.text = "Les humains n'existent plus,";

        //After we have waited 5 seconds print the time again.
        yield return new WaitForSeconds(2);
        unText.fontSize = 30;
        unText.text = "nous sommes leurs descendants.";

        yield return new WaitForSeconds(2);
        unText.fontSize = 35;
        unText.text = "Ma mission est de trouver...";


        yield return new WaitForSeconds(2);
        unText.fontSize = 40;
        unText.text = "...des artefacts anciens...";

        yield return new WaitForSeconds(2);
        unText.text = "et d'en apprendre plus...";

        yield return new WaitForSeconds(2);
        unText.text = "...sur cette civilisation.";

        yield return new WaitForSeconds(4);

        //uneimage.CrossFadeAlpha(1.0f, 3.0f, true);
        //uneimage.GetComponent<CanvasGroup>().alpha = 1; 

        // GameObject ledecors = GameObject.Find("background");
        // ledecors.GetComponent<Scrolling>().enabled = false; 

        // ledecors = GameObject.Find("floor");
        // ledecors.GetComponent<Scrolling>().enabled = false;

        // ledecors = GameObject.Find("Player");
        // ledecors.GetComponent<Scrolling>().enabled = false; 
        // ledecors.GetComponent<Animator>().enabled = false; 

        yield return new WaitForSeconds(2);
        uneimage.SetActive(true);
        LeanTween.alpha(uneimage.GetComponent<RectTransform>(), 1.0f, 2.0f);

        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Lvl1_ChoixTheme");  
    }
}
