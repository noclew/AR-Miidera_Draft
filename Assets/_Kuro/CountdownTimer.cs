using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class CountdownTimer : MonoBehaviour
{    
    public GameObject dialoguePanel;
    public float waitTime = 300f; //5f
    float timer;
    public float waitTime_2 = 20f;//2f

    bool wannaQuit;

    // Use this for initialization
    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            dialoguePanel.SetActive(true);
            if (timer > waitTime + waitTime_2)
            {
                Application.Quit();
                Debug.Log("should quit.");
            }
        }
    }
    public void CloseDialogue()
    {
        dialoguePanel.SetActive(false);
        timer = 0f;
    }
}
