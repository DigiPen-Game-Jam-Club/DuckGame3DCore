using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    GameObject UICanvas;
    EnterWorldScript CurrentWorld;
    Text WorldText;
    Button EnterWorldButton;
    // Start is called before the first frame update

    void GoToWorld()
    {
        if (CurrentWorld != null)
        {
            SceneManager.LoadScene(CurrentWorld.SceneName);
        }
    }
    void Start()
    {
        UICanvas = GameObject.Find("Canvas");
        WorldText = UICanvas.GetComponentInChildren<Text>();
        EnterWorldButton = UICanvas.GetComponentInChildren<Button>();
        EnterWorldButton.onClick.AddListener(GoToWorld);
        UICanvas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayWorldInfo(EnterWorldScript EnterWorld)
    {
        CurrentWorld = EnterWorld;
        WorldText.text = "Enter World " + CurrentWorld.WorldName;
        UICanvas.SetActive(true);
    }

    public void HideWorldInfo()
    {
        CurrentWorld = null;
        UICanvas.SetActive(false);
    }
}
