using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOnOffController : MonoBehaviour
{
    public GameObject modelGroup;
    public GameObject[] onModelList;
    // Use this for initialization
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked" + this.name);
        OffAll();
        OnObjs();
    }

    void OnObjs()
    {
        foreach (GameObject obj in onModelList)
        {
            obj.SetActive(true);
            //var rendererComponents = obj.GetComponentsInChildren<Renderer>(true);
            //var colliderComponents = obj.GetComponentsInChildren<Collider>(true);
            //var canvasComponents = obj.GetComponentsInChildren<Canvas>(true);

            //// Disable rendering:
            //foreach (var component in rendererComponents)
            //    component.enabled = true;

            //// Disable colliders:
            //foreach (var component in colliderComponents)
            //    component.enabled = true;

            //// Disable canvas':
            //foreach (var component in canvasComponents)
            //    component.enabled = true;
        }

    }

    void OffAll()
    {
        foreach (Transform child in modelGroup.transform)
        {
            child.gameObject.SetActive(false);
        }


    }
}
