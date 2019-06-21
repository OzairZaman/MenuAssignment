using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [Header("Menu UI Items")]
    public GameObject MainMenuPanel;
    public GameObject OptionMenuPanel;

    
    
    // Start is called before the first frame update
    void Start()
    {
        MainMenuPanel.SetActive(true);
        OptionMenuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MenuPlayClick()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuOptionClick()
    {
        MainMenuPanel.SetActive(false);
        OptionMenuPanel.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
