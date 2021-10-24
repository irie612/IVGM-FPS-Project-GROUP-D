using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinGame : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject canvas;
    private int index;

    public Transform player;
    private Rigidbody rb;

    public CharacterController cc;
    public GameObject goHelp;
    bool visited = false;

    void Start() 
    {
        canvas.gameObject.SetActive(false);
        textComponent.color = new Color(15, 98, 230, 255);
    }

    public void O() 
    {
        if(!visited) {
            goHelp.GetComponent<PlayerCharacterController>().enabled = false;
            visited = true;
        }

        canvas.gameObject.SetActive(true);
        textComponent.text = string.Empty;
        StartDialogue(); 
    }

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) 
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else 
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
      index = 0; 
      StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine()); 
        }
        else
        {
            gameObject.SetActive(false);
            goHelp.GetComponent<PlayerCharacterController>().enabled = true;
        }
    }
}
