using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class ClickCats : MonoBehaviour
{
    public TextMeshProUGUI catsFoundCountText;
    public TextMeshProUGUI catOutLawsFoundText;
    public TextMeshProUGUI postersFoundText;
    public TextMeshProUGUI hintsText;

    public static int catsFountCount, catOutlawFoundCount, posterFoundCount, hintsCount, hintsUsed;

    public GameObject poster1Found, poster2Found, poster3Found, poster4Found, poster5Found;
    public int savedPoster1, savedPoster2, savedPoster3, savedPoster4, savedPoster5;

    public int[] savedcatOutlawsFound = new int[5];
    public int[] savedCatsFound = new int[100];
    public GameObject[] catFound = new GameObject[100];
    public GameObject[] catOutlaws = new GameObject[5];

    public GameObject catOutlaw1, catOutlaw2, catOutlaw3, catOutlaw4, catOutlaw5;
    public int savedOutlaw1, savedOutlaw2, savedOutlaw3, savedOutlaw4, savedOutlaw5;

    public Vector2 catOutlaw1Pos1, catOutlaw1Pos2, catOutlaw1Pos3;
    public Vector2 catOutlaw2Pos1, catOutlaw2Pos2, catOutlaw2Pos3;
    public Vector2 catOutlaw3Pos1, catOutlaw3Pos2, catOutlaw3Pos3;
    public Vector2 catOutlaw4Pos1, catOutlaw4Pos2, catOutlaw4Pos3;
    public Vector2 catOutlaw5Pos1, catOutlaw5Pos2, catOutlaw5Pos3;

    void Start()
    {
        isInWinScreen = false;
        catsFountCount = PlayerPrefs.GetInt("savedCatsFound");
        catOutlawFoundCount = PlayerPrefs.GetInt("savedCatOutlaws");
        posterFoundCount = PlayerPrefs.GetInt("savedPostersFound");
        hintsCount = PlayerPrefs.GetInt("savedHints");
        hintsUsed = PlayerPrefs.GetInt("savedHintsUsed");
        hintsText.text = "" + hintsCount;

        //catsFountCount = 99;

        catsFoundCountText.text = catsFountCount + "/100";
        catOutLawsFoundText.text = catOutlawFoundCount + "/5";
        postersFoundText.text = posterFoundCount + "/5";

        catOutlaw1Pos1.x = -65.979f; catOutlaw1Pos1.y = -14.659f;
        catOutlaw1Pos2.x = -15.552f; catOutlaw1Pos2.y = -3.997f;
        catOutlaw1Pos3.x = -44.98f; catOutlaw1Pos3.y = -12.92f;

        catOutlaw2Pos1.x = -22.43f; catOutlaw2Pos1.y = 1.103f;
        catOutlaw2Pos2.x = -4.767f; catOutlaw2Pos2.y = -15.797f;
        catOutlaw2Pos3.x = 10.649f; catOutlaw2Pos3.y = -10.748f;

        catOutlaw3Pos1.x = -62.65f; catOutlaw3Pos1.y = -12.98f;
        catOutlaw3Pos2.x = 78.631f; catOutlaw3Pos2.y = -12.331f;
        catOutlaw3Pos3.x = 47.616f; catOutlaw3Pos3.y = -5.068f;

        catOutlaw4Pos1.x = -38f; catOutlaw4Pos1.y = -12.86f;
        catOutlaw4Pos2.x = 21.54f; catOutlaw4Pos2.y = -16.38f;
        catOutlaw4Pos3.x = -12.97f; catOutlaw4Pos3.y = -14.08f;

        catOutlaw5Pos1.x = -43.084f; catOutlaw5Pos1.y = 0.584f;
        catOutlaw5Pos2.x = -71.89f; catOutlaw5Pos2.y = -4.8f;
        catOutlaw5Pos3.x = -56.33f; catOutlaw5Pos3.y = -4.228f;

       
        for (int i = 0; i < 100; i++)
        {
            savedCatsFound[i] = PlayerPrefs.GetInt("saveCat" + (i + 1));

            //Debug.Log("saveCat" + (i + 1) + "=" + savedCatsFound[i]);

            if (savedCatsFound[i] == 1)
            {
                SetImageAlphaToOne(catFound[i].GetComponent<Image>());
                SetButtonInactive(catFound[i].GetComponent<Button>());
            }
        }

        savedPoster1 = PlayerPrefs.GetInt("savePoster1");
        savedPoster2 = PlayerPrefs.GetInt("savePoster2");
        savedPoster3 = PlayerPrefs.GetInt("savePoster3");
        savedPoster4 = PlayerPrefs.GetInt("savePoster4");
        savedPoster5 = PlayerPrefs.GetInt("savePoster5");

        if(savedPoster1 == 1)
        {
            SetImageAlphaToOne(poster1Found.GetComponent<Image>());
            SetButtonInactive(poster1Found.GetComponent<Button>());

            outlaw1PosX = PlayerPrefs.GetFloat("saveOutlaw1PosX");
            outlaw1PosY = PlayerPrefs.GetFloat("saveOutlaw1PosY");
            catOutlaw1.SetActive(true);
            catOutlaw1.transform.localPosition = new Vector2(outlaw1PosX, outlaw1PosY);
        }
        if (savedPoster2 == 1)
        {
            SetImageAlphaToOne(poster2Found.GetComponent<Image>());
            SetButtonInactive(poster2Found.GetComponent<Button>());

            outlaw2PosX = PlayerPrefs.GetFloat("saveOutlaw2PosX");
            outlaw2PosY = PlayerPrefs.GetFloat("saveOutlaw2PosY");
            catOutlaw2.SetActive(true);
            catOutlaw2.transform.localPosition = new Vector2(outlaw2PosX, outlaw2PosY);
        }
        if (savedPoster3 == 1)
        {
            SetImageAlphaToOne(poster3Found.GetComponent<Image>());
            SetButtonInactive(poster3Found.GetComponent<Button>());

            outlaw3PosX = PlayerPrefs.GetFloat("saveOutlaw3PosX");
            outlaw3PosY = PlayerPrefs.GetFloat("saveOutlaw3PosY");
            catOutlaw3.SetActive(true);
            catOutlaw3.transform.localPosition = new Vector2(outlaw3PosX, outlaw3PosY);
        }
        if (savedPoster4 == 1)
        {
            SetImageAlphaToOne(poster4Found.GetComponent<Image>());
            SetButtonInactive(poster4Found.GetComponent<Button>());

            outlaw4PosX = PlayerPrefs.GetFloat("saveOutlaw4PosX");
            outlaw4PosY = PlayerPrefs.GetFloat("saveOutlaw4PosY");
            catOutlaw4.SetActive(true);
            catOutlaw4.transform.localPosition = new Vector2(outlaw4PosX, outlaw4PosY);
        }
        if (savedPoster5 == 1)
        {
            SetImageAlphaToOne(poster5Found.GetComponent<Image>());
            SetButtonInactive(poster5Found.GetComponent<Button>());

            outlaw5PosX = PlayerPrefs.GetFloat("saveOutlaw5PosX");
            outlaw5PosY = PlayerPrefs.GetFloat("saveOutlaw5PosY");
            catOutlaw5.SetActive(true);
            catOutlaw5.transform.localPosition = new Vector2(outlaw5PosX, outlaw5PosY);
        }

        savedcatOutlawsFound[0] = PlayerPrefs.GetInt("savedFoundvatOutlaw1");
        savedcatOutlawsFound[1] = PlayerPrefs.GetInt("savedFoundvatOutlaw2");
        savedcatOutlawsFound[2] = PlayerPrefs.GetInt("savedFoundvatOutlaw3");
        savedcatOutlawsFound[3] = PlayerPrefs.GetInt("savedFoundvatOutlaw4");
        savedcatOutlawsFound[4] = PlayerPrefs.GetInt("savedFoundvatOutlaw5");

        if (savedcatOutlawsFound[0] == 1) 
        {
            SetImageAlphaToOne(catOutlaws[0].GetComponent<Image>());
            SetButtonInactive(catOutlaws[0].GetComponent<Button>());
        }
        if (savedcatOutlawsFound[1] == 1)
        {
            SetImageAlphaToOne(catOutlaws[1].GetComponent<Image>());
            SetButtonInactive(catOutlaws[1].GetComponent<Button>());
        }
        if (savedcatOutlawsFound[2] == 1)
        {
            SetImageAlphaToOne(catOutlaws[2].GetComponent<Image>());
            SetButtonInactive(catOutlaws[2].GetComponent<Button>());
        }
        if (savedcatOutlawsFound[3] == 1)
        {
            SetImageAlphaToOne(catOutlaws[3].GetComponent<Image>());
            SetButtonInactive(catOutlaws[3].GetComponent<Button>());
        }
        if (savedcatOutlawsFound[4] == 1)
        {
            SetImageAlphaToOne(catOutlaws[4].GetComponent<Image>());
            SetButtonInactive(catOutlaws[4].GetComponent<Button>());
        }
    }

    public void ClickCat(GameObject clickedCat)
    {
        if (Settings.isInMainMenu == false || Settings.isInSettings == false)
        {
            // Find the index of the clickedCat in the catFound array
            int catIndex = Array.IndexOf(catFound, clickedCat);
            SetImageAlphaToOne(clickedCat.GetComponent<Image>());
            SetButtonInactive(clickedCat.GetComponent<Button>());

            // Check if the cat was found in the array
            if (catIndex != -1)
            {
                savedCatsFound[catIndex] = 1;

                PlayerPrefs.SetInt("saveCat" + (catIndex + 1), savedCatsFound[catIndex]);
                //Debug.Log("Clicked cat index: " + "saveCat" + (catIndex + 1));
            }
            else
            {
                // The clicked cat was not found in the array
                Debug.LogError("Clicked cat not found in the array");
            }

            FindObjectOfType<AudioManager>().Play("ClickCat");

            Invoke("MeowSounds", 0.2f);

            catsFountCount += 1;
            catsFoundCountText.text = catsFountCount + "/100";
            PlayerPrefs.SetInt("savedCatsFound", catsFountCount);

            arrow.SetActive(false);
            hintCircle.SetActive(false);
            blockHints.SetActive(false);

            StopCoroutine();
            CheckAchievements();
            CheckWin();
        }
    }

    #region posters

    public float outlaw1PosX, outlaw1PosY, outlaw2PosX, outlaw2PosY, outlaw3PosX, outlaw3PosY, outlaw4PosX, outlaw4PosY, outlaw5PosX, outlaw5PosY;

    public void ClickPoster1()
    {
        if (Settings.isInMainMenu == false || Settings.isInSettings == false)
        {
            plussPoster();
            SetImageAlphaToOne(poster1Found.GetComponent<Image>());
            SetButtonInactive(poster1Found.GetComponent<Button>());
            savedPoster1 = 1;
            PlayerPrefs.SetInt("savePoster1", savedPoster1);

            int random = UnityEngine.Random.Range(1, 4);
            catOutlaw1.SetActive(true);
            if (random == 1) { catOutlaw1.transform.localPosition = catOutlaw1Pos1; }
            if (random == 2) { catOutlaw1.transform.localPosition = catOutlaw1Pos2; }
            if (random == 3) { catOutlaw1.transform.localPosition = catOutlaw1Pos3; }

            outlaw1PosX = catOutlaw1.transform.localPosition.x;
            outlaw1PosY = catOutlaw1.transform.localPosition.y;
            PlayerPrefs.SetFloat("saveOutlaw1PosX", outlaw1PosX);
            PlayerPrefs.SetFloat("saveOutlaw1PosY", outlaw1PosY);

            ClickPoser();
            StopCoroutine();
        }
    }

    public void ClickPoster2()
    {
        if (Settings.isInMainMenu == false || Settings.isInSettings == false)
        {
            plussPoster();
            SetImageAlphaToOne(poster2Found.GetComponent<Image>());
            SetButtonInactive(poster2Found.GetComponent<Button>());
            savedPoster2 = 1;
            PlayerPrefs.SetInt("savePoster2", savedPoster2);

            int random = UnityEngine.Random.Range(1, 4);
            catOutlaw2.SetActive(true);
            if (random == 1) { catOutlaw2.transform.localPosition = catOutlaw2Pos1; }
            if (random == 2) { catOutlaw2.transform.localPosition = catOutlaw2Pos2; }
            if (random == 3) { catOutlaw2.transform.localPosition = catOutlaw2Pos3; }

            outlaw2PosX = catOutlaw2.transform.localPosition.x;
            outlaw2PosY = catOutlaw2.transform.localPosition.y;

            PlayerPrefs.SetFloat("saveOutlaw2PosX", outlaw2PosX);
            PlayerPrefs.SetFloat("saveOutlaw2PosY", outlaw2PosY);

            ClickPoser();
            StopCoroutine();
        }
    }

    public void ClickPoster3()
    {
        if (Settings.isInMainMenu == false || Settings.isInSettings == false)
        {
            plussPoster();
            SetImageAlphaToOne(poster3Found.GetComponent<Image>());
            SetButtonInactive(poster3Found.GetComponent<Button>());
            savedPoster3 = 1;
            PlayerPrefs.SetInt("savePoster3", savedPoster3);

            int random = UnityEngine.Random.Range(1, 4);
            catOutlaw3.SetActive(true);
            if (random == 1) { catOutlaw3.transform.localPosition = catOutlaw3Pos1; }
            if (random == 2) { catOutlaw3.transform.localPosition = catOutlaw3Pos2; }
            if (random == 3) { catOutlaw3.transform.localPosition = catOutlaw3Pos3; }

            outlaw3PosX = catOutlaw3.transform.localPosition.x;
            outlaw3PosY = catOutlaw3.transform.localPosition.y;

            PlayerPrefs.SetFloat("saveOutlaw3PosX", outlaw3PosX);
            PlayerPrefs.SetFloat("saveOutlaw3PosY", outlaw3PosY);

            ClickPoser();
            StopCoroutine();
        }
    }

    public void ClickPoster4()
    {
        if (Settings.isInMainMenu == false || Settings.isInSettings == false)
        {
            plussPoster();
            SetImageAlphaToOne(poster4Found.GetComponent<Image>());
            SetButtonInactive(poster4Found.GetComponent<Button>());
            savedPoster4 = 1;
            PlayerPrefs.SetInt("savePoster4", savedPoster4);

            int random = UnityEngine.Random.Range(1, 4);
            catOutlaw4.SetActive(true);
            if (random == 1) { catOutlaw4.transform.localPosition = catOutlaw4Pos1; }
            if (random == 2) { catOutlaw4.transform.localPosition = catOutlaw4Pos2; }
            if (random == 3) { catOutlaw4.transform.localPosition = catOutlaw4Pos3; }

            outlaw4PosX = catOutlaw4.transform.localPosition.x;
            outlaw4PosY = catOutlaw4.transform.localPosition.y;

            PlayerPrefs.SetFloat("saveOutlaw4PosX", outlaw4PosX);
            PlayerPrefs.SetFloat("saveOutlaw4PosY", outlaw4PosY);

            ClickPoser();
            StopCoroutine();
        }
    }

    public void ClickPoster5()
    {
        if (Settings.isInMainMenu == false || Settings.isInSettings == false)
        {
            plussPoster();
            SetImageAlphaToOne(poster5Found.GetComponent<Image>());
            SetButtonInactive(poster5Found.GetComponent<Button>());
            savedPoster5 = 1;
            PlayerPrefs.SetInt("savePoster5", savedPoster5);

            int random = UnityEngine.Random.Range(1, 4);
            catOutlaw5.SetActive(true);
            if (random == 1) { catOutlaw5.transform.localPosition = catOutlaw5Pos1; }
            if (random == 2) { catOutlaw5.transform.localPosition = catOutlaw5Pos2; }
            if (random == 3) { catOutlaw5.transform.localPosition = catOutlaw5Pos3; }

            outlaw5PosX = catOutlaw5.transform.localPosition.x;
            outlaw5PosY = catOutlaw5.transform.localPosition.y;

            PlayerPrefs.SetFloat("saveOutlaw5PosX", outlaw5PosX);
            PlayerPrefs.SetFloat("saveOutlaw5PosY", outlaw5PosY);

            ClickPoser();
            StopCoroutine();
        }
    }

    public void plussPoster()
    {
        posterFoundCount += 1;
        postersFoundText.text = posterFoundCount + "/5";
        PlayerPrefs.SetInt("savedPostersFound", posterFoundCount);

        hintsCount += 1;
        hintsText.text = hintsCount + "";
        PlayerPrefs.SetInt("savedHints", hintsCount);
        CheckAchievements();
        CheckWin();
    }

    public void ClickPoser()
    {
        arrow.SetActive(false);
        hintCircle.SetActive(false);
        blockHints.SetActive(false);

        int random = UnityEngine.Random.Range(1, 3);
        if (random == 1) { FindObjectOfType<AudioManager>().Play("Poster1"); }
        if (random == 2) { FindObjectOfType<AudioManager>().Play("Poster2"); }
    }
    #endregion

    #region Cat outlaws
    public void ClickCatOutlaw(int outlawNumber)
    {
        if(outlawNumber == 1)
        {
            savedcatOutlawsFound[0] = 1;
            PlayerPrefs.SetInt("savedFoundvatOutlaw1", savedcatOutlawsFound[0]);
            SetImageAlphaToOne(catOutlaws[0].GetComponent<Image>());
            SetButtonInactive(catOutlaws[0].GetComponent<Button>());
        }
        if (outlawNumber == 2)
        {
            savedcatOutlawsFound[1] = 1;
            PlayerPrefs.SetInt("savedFoundvatOutlaw2", savedcatOutlawsFound[1]);
            SetImageAlphaToOne(catOutlaws[1].GetComponent<Image>());
            SetButtonInactive(catOutlaws[1].GetComponent<Button>());
        }
        if (outlawNumber == 3)
        {
            savedcatOutlawsFound[2] = 1;
            PlayerPrefs.SetInt("savedFoundvatOutlaw3", savedcatOutlawsFound[2]);
            SetImageAlphaToOne(catOutlaws[2].GetComponent<Image>());
            SetButtonInactive(catOutlaws[2].GetComponent<Button>());
        }
        if (outlawNumber == 4)
        {
            savedcatOutlawsFound[3] = 1;
            PlayerPrefs.SetInt("savedFoundvatOutlaw4", savedcatOutlawsFound[3]);
            SetImageAlphaToOne(catOutlaws[3].GetComponent<Image>());
            SetButtonInactive(catOutlaws[3].GetComponent<Button>());
        }
        if (outlawNumber == 5)
        {
            savedcatOutlawsFound[4] = 1;
            PlayerPrefs.SetInt("savedFoundvatOutlaw5", savedcatOutlawsFound[4]);
            SetImageAlphaToOne(catOutlaws[4].GetComponent<Image>());
            SetButtonInactive(catOutlaws[4].GetComponent<Button>());
        }

        catOutlawFoundCount += 1;
        PlayerPrefs.SetInt("savedCatOutlaws", catOutlawFoundCount);
        FindObjectOfType<AudioManager>().Play("ClickCat");
        Invoke("MeowSounds", 0.2f);

        catOutLawsFoundText.text = catOutlawFoundCount + "/5";
        StopCoroutine();
        CheckAchievements();
        CheckWin();

        hintsCount += 1;
        hintsText.text = hintsCount + "";
        PlayerPrefs.SetInt("savedHints", hintsCount);
    }
    #endregion

    public void StopCoroutine()
    {
        if (moveArrowCourine != null) { StopCoroutine(moveArrowCourine); moveArrowCourine = null; }
        if (waitCircleCoroutine != null) { StopCoroutine(waitCircleCoroutine); waitCircleCoroutine = null; }

        arrow.SetActive(false);
        hintCircle.SetActive(false);
        blockHints.SetActive(false);
    }

    public void SetImageAlphaToOne(Image image)
    {
        Color currentColor = image.color;
        currentColor.a = 1f; 
        image.color = currentColor;
    }

    public void SetButtonInactive(Button button)
    {
        button.interactable = false;
    }

    public void MeowSounds()
    {
        int random = UnityEngine.Random.Range(1,9);
        if (random == 1) { FindObjectOfType<AudioManager>().Play("Meow1"); }
        if (random == 2) { FindObjectOfType<AudioManager>().Play("Meow2"); }
        if (random == 3) { FindObjectOfType<AudioManager>().Play("Meow3"); }
        if (random == 4) { FindObjectOfType<AudioManager>().Play("Meow4"); }
        if (random == 5) { FindObjectOfType<AudioManager>().Play("Meow5"); }
        if (random == 6) { FindObjectOfType<AudioManager>().Play("Meow6"); }
        if (random == 7) { FindObjectOfType<AudioManager>().Play("Meow7"); }
        if (random == 8) { FindObjectOfType<AudioManager>().Play("Meow8"); }
    }

    #region Hints
    //Hints
    public GameObject hintCircle;
    public GameObject blockHints;
    public GameObject arrow;
    public float arrowSpeed = 2f;
    public Transform arrowSpawnPoint;
    public float randomRange = 50f;
    public bool catOrOutlaw;
    public void useHint()
    {
        //if (hintsCount == 0) { FindObjectOfType<AudioManager>().Play("NoHints"); }

        if (hintsCount > 0)
        {
            hintsUsed += 1;
            PlayerPrefs.SetInt("savedHintsUsed", hintsUsed);
            FindObjectOfType<AudioManager>().Play("Click");
            hintsCount -= 1;
            hintsText.text = "" + hintsCount;
            PlayerPrefs.SetInt("savedHints", hintsCount);
            blockHints.SetActive(true);
            List<int> inactiveIndices = new List<int>();

            for (int i = 0; i < catFound.Length; i++)
            {
                Image catImage = catFound[i].GetComponent<Image>();
                if (catImage != null && catImage.color.a == 0f)
                {
                    inactiveIndices.Add(i);
                    catOrOutlaw = true;
                }
            }

            if (inactiveIndices.Count == 0)
            {
                Debug.Log("No more cats to find. Check outlaws.");

                for (int i = 0; i < catOutlaws.Length; i++)
                {
                    Image catImage = catOutlaws[i].GetComponent<Image>();
                    if (catImage != null && catImage.color.a == 0f)
                    {
                        inactiveIndices.Add(i);
                        Debug.Log("Outlaws found");
                        catOrOutlaw = false;
                    }
                }
            }

            if (inactiveIndices.Count == 0)
            {
                Debug.Log("Everything is found.");

                return;
            }

            int randomIndex = inactiveIndices[UnityEngine.Random.Range(0, inactiveIndices.Count)];
            if(catOrOutlaw == true) 
            { 
                Vector3 position = catFound[randomIndex].transform.position;
                position.x += UnityEngine.Random.Range(-randomRange, randomRange);
                position.y += UnityEngine.Random.Range(-randomRange, randomRange);

                hintCircle.transform.position = position;
            }

            if (catOrOutlaw == false)
            {
                Vector3 position = catOutlaws[randomIndex].transform.position;
                position.x += UnityEngine.Random.Range(-randomRange, randomRange);
                position.y += UnityEngine.Random.Range(-randomRange, randomRange);

                hintCircle.transform.position = position;
            }

            hintCircle.SetActive(true);
            //Debug.Log(hintCircle.activeInHierarchy);

            // Set arrow active and move it towards hintCircle
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(4f, -4f, 0f);
            mousePos.z = 0f;
            arrow.transform.position = mousePos;

            Vector3 direction = hintCircle.transform.position - arrow.transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            arrow.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

            arrow.SetActive(true);
            moveArrowCourine = StartCoroutine(MoveArrow(arrow, hintCircle.transform.position));

            waitCircleCoroutine = StartCoroutine(waitCircle());
        }

    }

    public Coroutine waitCircleCoroutine, moveArrowCourine;
    IEnumerator waitCircle()
    {
        yield return new WaitForSeconds(12);
        blockHints.SetActive(false);
        hintCircle.SetActive(false);
        arrow.SetActive(false);
    }

    IEnumerator MoveArrow(GameObject arrow, Vector3 targetPos)
    {
        while (Vector3.Distance(arrow.transform.position, targetPos) > 1.3f)
        {
            arrow.transform.position = Vector3.MoveTowards(arrow.transform.position, targetPos, arrowSpeed * Time.deltaTime);
            yield return null;
        }

        // Set arrow inactive when it reaches the hintCircle
        arrow.SetActive(false);
    }
    #endregion

    public Achievements achScripts;
    public void CheckAchievements()
    {
        achScripts.CheckAchievements();
    }

    public void ResetGame()
    {
        hintsUsed = 0;

        PlayerPrefs.SetInt("savedHintsUsed", hintsUsed);

        catsFountCount = 0;
        catOutlawFoundCount = 0;
        posterFoundCount = 0;
        hintsCount = 0;
        hintsText.text = "" + hintsCount;
        catsFoundCountText.text = catsFountCount + "/100";
        catOutLawsFoundText.text = catOutlawFoundCount + "/5";
        postersFoundText.text = posterFoundCount + "/5";

        PlayerPrefs.SetInt("savedCatsFound", catsFountCount);

        SetAlphaTo0(poster1Found.GetComponent<Image>());
        SetButtonActive(poster1Found.GetComponent<Button>());

        SetAlphaTo0(poster2Found.GetComponent<Image>());
        SetButtonActive(poster2Found.GetComponent<Button>());

        SetAlphaTo0(poster3Found.GetComponent<Image>());
        SetButtonActive(poster3Found.GetComponent<Button>());

        SetAlphaTo0(poster4Found.GetComponent<Image>());
        SetButtonActive(poster4Found.GetComponent<Button>());

        SetAlphaTo0(poster5Found.GetComponent<Image>());
        SetButtonActive(poster5Found.GetComponent<Button>());

        PlayerPrefs.SetInt("savedPostersFound", posterFoundCount);
        PlayerPrefs.SetInt("savedHints", hintsCount);

        savedPoster1 = 0; savedPoster2 = 0; savedPoster3 = 0; savedPoster4 = 0; savedPoster5 = 0;
        PlayerPrefs.SetInt("savePoster1", savedPoster1);
        PlayerPrefs.SetInt("savePoster2", savedPoster2);
        PlayerPrefs.SetInt("savePoster3", savedPoster3);
        PlayerPrefs.SetInt("savePoster4", savedPoster4);
        PlayerPrefs.SetInt("savePoster5", savedPoster5);

        //Outlaws
        SetAlphaTo0(catOutlaws[0].GetComponent<Image>());
        SetButtonActive(catOutlaws[0].GetComponent<Button>());

        SetAlphaTo0(catOutlaws[1].GetComponent<Image>());
        SetButtonActive(catOutlaws[1].GetComponent<Button>());

        SetAlphaTo0(catOutlaws[2].GetComponent<Image>());
        SetButtonActive(catOutlaws[2].GetComponent<Button>());

        SetAlphaTo0(catOutlaws[3].GetComponent<Image>());
        SetButtonActive(catOutlaws[3].GetComponent<Button>());

        SetAlphaTo0(catOutlaws[4].GetComponent<Image>());
        SetButtonActive(catOutlaws[4].GetComponent<Button>());

        PlayerPrefs.SetInt("savedCatOutlaws", catOutlawFoundCount);

        savedcatOutlawsFound[0] = 0;
        savedcatOutlawsFound[1] = 0;
        savedcatOutlawsFound[2] = 0;
        savedcatOutlawsFound[3] = 0;
        savedcatOutlawsFound[4] = 0;
        PlayerPrefs.SetInt("savedFoundvatOutlaw1", savedcatOutlawsFound[0]);
        PlayerPrefs.SetInt("savedFoundvatOutlaw2", savedcatOutlawsFound[1]);
        PlayerPrefs.SetInt("savedFoundvatOutlaw3", savedcatOutlawsFound[2]);
        PlayerPrefs.SetInt("savedFoundvatOutlaw4", savedcatOutlawsFound[3]);
        PlayerPrefs.SetInt("savedFoundvatOutlaw5", savedcatOutlawsFound[4]);

        for (int i = 0; i < catFound.Length; i++)
        {
            Image catImage = catFound[i].GetComponent<Image>();
            SetAlphaTo0(catImage);
            SetButtonActive(catImage.gameObject.GetComponent<Button>());
        }

        catOutlaw1.SetActive(false); catOutlaw2.SetActive(false); catOutlaw3.SetActive(false); catOutlaw4.SetActive(false); catOutlaw5.SetActive(false);

        for (int i = 0; i < 100; i++)
        {
            savedCatsFound[i] = 0;

            PlayerPrefs.SetInt("saveCat" + (i + 1), savedCatsFound[i]);
            //Debug.Log("saveCat " + (i + 1));

        }

    }

    public void SetAlphaTo0(Image image)
    {
        Color currentColor = image.color;
        currentColor.a = 0f;
        image.color = currentColor;
    }

    public void SetButtonActive(Button button)
    {
        button.interactable = true;
    }

    public GameObject winScreen, winSCreenUIElements;

    #region Win
    public void CheckWin()
    {
        if(catsFountCount > 99 && posterFoundCount > 4 && catOutlawFoundCount > 4)
        {
            StartCoroutine(WinAnim());
        }
    }

    public static bool isInWinScreen;
    IEnumerator WinAnim()
    {
        isInWinScreen = true;
        FindObjectOfType<AudioManager>().Play("win1");
        yield return new WaitForSeconds(1f);
        winScreen.SetActive(true);
        winScreen.GetComponent<Animation>().Play("winAnim");
        FindObjectOfType<AudioManager>().Play("win2");
        yield return new WaitForSeconds(0.333f);
        winSCreenUIElements.SetActive(true);
        winScreen.GetComponent<Animation>().Play("winWave");
    }

    public void CloseWin()
    {
        isInWinScreen = false;
        FindObjectOfType<AudioManager>().Play("Click");
        winScreen.SetActive(false);
        winSCreenUIElements.SetActive(false);
    }
    #endregion
}
