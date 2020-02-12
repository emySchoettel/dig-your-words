using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Reward : MonoBehaviour
{

    public GameObject uneRecompense;
    public GameObject[] lesMines;
    private bool[] boolres;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //si c'est cliqué vérifier si les mines
        for(int i = 0; i < lesMines.Length - 1; i++)
        {
            Debug.Log(i);
            if (lesMines[i] == null)
            {
                boolres[i] = true; 
                Debug.Log("vrai");
            }
        }

        if (boolres.Length == 9)
            Debug.Log("terminé");
      /*  if (verifsBool())
        {
            Debug.Log("vrai");
        }
        else
            Debug.Log("faux");
        //afficher le panel, un message  et passer à la scene suivante 

        StartCoroutine(LeText());*/

    }

    IEnumerator LeText()
    {
        Text unText = GameObject.Find("Informations").GetComponent<Text>();
        unText.text = "Je n'ai pas retiré toutes les mines autour de l'artefact...";
        yield return new WaitForSeconds(2);
        unText.text = "Je creuse... Je creuse...";
    }

    bool[] verifMines()
    {
        int i = 0;  
        while (lesMines[i] == null && i < lesMines.Length - 1)
        {
            boolres[i] = true;
            i++;
        }
        return boolres; 
    }

    bool verifsBool()
    {
        bool[] desBoolsMines = verifMines();
        bool res = false;
        int i = 0;
        while(desBoolsMines[i] && i < desBoolsMines.Length - 1)
        {
            res = true; 
        }
        return res; 

    }
}
