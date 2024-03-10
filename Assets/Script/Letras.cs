using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Letras : MonoBehaviour
{
   

    public TextMeshProUGUI dialogueText;
    public string[] palabras;
    public float tiempo = 0.1f;
    int index;
    void Start()
    {
        dialogueText.text = string.Empty;
        startDialoge();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(dialogueText.text == palabras[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = palabras[index];
            }
        }
    }

    public void startDialoge()
    {
        index = 0;
        StartCoroutine(WriteLine());
    }


    IEnumerator WriteLine()
    {

        foreach (char letra in palabras[index].ToCharArray())
        {
            dialogueText.text += letra;
            yield return new WaitForSeconds(tiempo);
        }
    
    }

    public void NextLine()
    {
        if(index < palabras.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
