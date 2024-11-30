using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject settingScreen;
    public static bool isInSettings, isInMainMenu;
    public GameObject logo, mainMenuButtons, hintsBtn, settingBtn, outlawCats, posters, cats;

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Music");
        isInMainMenu = true;

        changeRes = false;

        // Define a list of supported resolutions
        resolutions = new List<Resolution>
        {
            new Resolution { width = 800, height = 600 },
            new Resolution { width = 1024, height = 768 },
            new Resolution { width = 1280, height = 720 },
            new Resolution { width = 1280, height = 800 },
            new Resolution { width = 1280, height = 1024 },
            new Resolution { width = 1366, height = 768 },
            new Resolution { width = 1600, height = 900 },
            new Resolution { width = 1920, height = 1080 },
            new Resolution { width = 1920, height = 1200 },
            new Resolution { width = 2560, height = 1440 },
            new Resolution { width = 2560, height = 1600 },
            new Resolution { width = 2560, height = 1080 },
            new Resolution { width = 3440, height = 1440 },
            new Resolution { width = 3840, height = 1440 },
            new Resolution { width = 3840, height = 2160 },
            new Resolution { width = 3840, height = 2400 }
            // Add any other resolutions you want to support here
        };

        // Add the supported resolutions to the dropdown
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Count; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    void Update()
    {
        if(ClickCats.isInWinScreen == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                FindObjectOfType<AudioManager>().Play("Click");
                if (settingScreen.activeInHierarchy == false)
                {
                    settingScreen.SetActive(true);
                    isInSettings = true;
                }
                else
                {
                    settingScreen.SetActive(false);
                    isInSettings = false;
                }
            }
        }
    }

    #region Resolution
    public Camera cameraMain;

    // List of available resolutions
    private List<Resolution> resolutions = new List<Resolution>();
    public TMP_Dropdown resolutionDropdown;

    public static bool changeRes;
    public static bool isNormalRes;

    public void SetResolution(int resolutionIndex)
    {
        //cameraMain.transform.position = new Vector3(0, 0, 0);
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        changeRes = true;
    }
    #endregion

    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        isInMainMenu = false;
        logo.GetComponent<Animation>().Play("fadeAnim");
        mainMenuButtons.GetComponent<Animation>().Play("buttonDown");

        hintsBtn.SetActive(true);
        settingBtn.SetActive(true);
        outlawCats.SetActive(true);
        posters.SetActive(true);
        cats.SetActive(true);

        hintsBtn.GetComponent<Animation>().Play("UIElementDown");
        settingBtn.GetComponent<Animation>().Play("UIElementDown");
        outlawCats.GetComponent<Animation>().Play("UIElementDown");
        posters.GetComponent<Animation>().Play("UIElementDown");
        cats.GetComponent<Animation>().Play("UIElementDown");
    }

    IEnumerator Waitanim()
    {
        yield return new WaitForSeconds(2);
        logo.SetActive(false);
        mainMenuButtons.SetActive(false);
    }

    public void OptionsButton()
    {
        if (ClickCats.isInWinScreen == false)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            settingScreen.SetActive(true);
            isInSettings = true;
        }
    }

    public void ExitGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Application.Quit();
    }

    public void ExitSettings()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        settingScreen.SetActive(false);
        isInSettings = false;
    }

    public GameObject resetGameScreen;
    public void ResetGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        resetGameScreen.SetActive(true);
    }

    public ClickCats catsScript;
    public GameObject winScreen, winSCreenUIElements;
    public void YesReset()
    {
        ClickCats.isInWinScreen = false;
        winScreen.SetActive(false);
        winSCreenUIElements.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Click");
        resetGameScreen.SetActive(false);
        catsScript.ResetGame();
    }

    public void NoReset()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        resetGameScreen.SetActive(false);
    }

    public void SetUIElements()
    {
        FindObjectOfType<AudioManager>().Play("Click");
    }

    public void BackToMainMenu()
    {
        ClickCats.isInWinScreen = false;
        FindObjectOfType<AudioManager>().Play("Click");
        if (hintsBtn.activeInHierarchy == true) { hintsBtn.GetComponent<Animation>().Play("UIElementUp"); }
        if (settingBtn.activeInHierarchy == true) { settingBtn.GetComponent<Animation>().Play("UIElementUp"); }
        if (outlawCats.activeInHierarchy == true) { outlawCats.GetComponent<Animation>().Play("UIElementUp"); }
        if (posters.activeInHierarchy == true) { posters.GetComponent<Animation>().Play("UIElementUp"); }
        if (cats.activeInHierarchy == true) { cats.GetComponent<Animation>().Play("UIElementUp"); }

        settingScreen.SetActive(false);
        winScreen.SetActive(false);
        winSCreenUIElements.SetActive(false);
        if(isInMainMenu == false)
        {
            logo.SetActive(true);
            logo.GetComponent<Animation>().Play("fadeOut");
            mainMenuButtons.SetActive(true);
            mainMenuButtons.GetComponent<Animation>().Play("buttonsUp");
        }
        isInMainMenu = true;
        isInSettings = false;
    }

    public GameObject uiBtnOff, uiBtnOn;

    public void UIOn()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        uiBtnOn.SetActive(true); uiBtnOff.SetActive(false);
        settingBtn.SetActive(true); hintsBtn.SetActive(true); posters.SetActive(true); cats.SetActive(true); outlawCats.SetActive(true);
    }

    public void UIOff()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        uiBtnOn.SetActive(false); uiBtnOff.SetActive(true);
        settingBtn.SetActive(false); hintsBtn.SetActive(false); posters.SetActive(false); cats.SetActive(false); outlawCats.SetActive(false);
    }

    public GameObject fullscreenOffBtn, fllscreenOnBtn;
    public void SetFullSCreen()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        fullscreenOffBtn.SetActive(false);
        fllscreenOnBtn.SetActive(true);
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
    }

    public void SetWindowed()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        fullscreenOffBtn.SetActive(true);
        fllscreenOnBtn.SetActive(false);
        Screen.fullScreenMode = FullScreenMode.Windowed;
    }

    public void OpenSteamLink()
    {
        Application.OpenURL("https://store.steampowered.com/curator/43674917-Simon-Eftestol/list/112339");
    }

}
