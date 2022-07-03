using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterWorldScript : MonoBehaviour
{
    UIManagerScript UIManager;
    public string WorldName;
    public string SceneName;
    // Start is called before the first frame update


    void Start()
    {
        UIManager = GameObject.Find("UIManager").GetComponent<UIManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            UIManager.DisplayWorldInfo(this);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            UIManager.HideWorldInfo();
        }
    }
}
