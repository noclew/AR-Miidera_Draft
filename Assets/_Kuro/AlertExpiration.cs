using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class AlertExpiration : MonoBehaviour
{    
    public GameObject dialoguePanel;
    public System.DateTime dateExpired = new System.DateTime(2018,12,31,23,59,59);
    //public System.DateTime dateExpired = new System.DateTime(2018, 7, 5, 11, 01, 30);//for debugging

    // Use this for initialization
    void Start()
    {
        dialoguePanel.SetActive(false);
        System.DateTime now = System.DateTime.Now;
        if (now > dateExpired)
        {
            //EditorUtility.DisplayDialog("Alert", "This application is out of date. Please download a new version.", "OK.","");
            dialoguePanel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void CloseDialogue()
    {
        dialoguePanel.SetActive(false);
    }
}

