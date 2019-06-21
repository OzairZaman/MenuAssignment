using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [Header("Menu UI Items")]
    public GameObject MainMenuPanel;
    public GameObject OptionMenuPanel;
    public Dropdown resDropdown;

    [Header("Audio stuffs")]
    public AudioMixer mixer;

    [Header("resolution stuffs")]
    Resolution[] resolutions;
    List<string> resList = new List<string>();
    int currentResolutionIndex = 0;


    void Start()
    {
        resolutions = Screen.resolutions;

        // setting up the resolution option dropdown.
        //clear options from dropdown
        resDropdown.ClearOptions();

        //We got an array of resolutions
        //we got us a dropdown
        //we got a list of Strings
        //we gon create us here a list of string out of our array of resolutions
        //so we can drop that list of string into the AddOptions method of our dropdown Object
        //and thus populating the dropdown's options with our array of resolutions
        //got it?
        for (int i = 0; i < resolutions.Length; i++)
        {
           string s = resolutions[i].width + "x" + resolutions[i].height;
            resList.Add(s);

            //check the curent resolution of our LIST OF RESOLUTIONS and see if it is the same as the system(?) resolution
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                //if same remember that shit!!!
                currentResolutionIndex = i;
                Debug.Log(i);
            }
        }
        //add the 
        resDropdown.AddOptions(resList);
        //now set the default value of our dropdow
        resDropdown.value = currentResolutionIndex;
        //refresh that shit ...umm not sure why..something something unity something something
        resDropdown.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuBackClick()
    {
        MainMenuPanel.SetActive(true);
        OptionMenuPanel.SetActive(false);
        Debug.Log("Clicked back");
    }

    public void SetVolume(float v)
    {
        mixer.SetFloat("Volume", v);
    }

    public void SetGFXQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

    public void SetResolution(int i)
    {
        Screen.SetResolution(resolutions[i].width, resolutions[i].height, Screen.fullScreen);
    }

    public void ScreenMode(bool full)
    {
        Screen.fullScreen = full;
    }
}
