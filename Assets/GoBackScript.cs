using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GoBackScript : MonoBehaviour
{
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(GoBack);
    }

    void GoBack()
    {
        SceneManager.LoadScene("HubWorld");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
