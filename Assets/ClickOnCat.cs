using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnCat : MonoBehaviour
{
    public void ClickCat()
    {
        if(Settings.isInMainMenu == false || Settings.isInSettings == false)
        {
            ClickCats clickCatsCript = GetComponent<ClickCats>();

            if (clickCatsCript != null)
            {
                // Find the index of the current GameObject in the array
                int index = System.Array.IndexOf(clickCatsCript.catFound, gameObject);

                if (index != -1)
                {
                    Debug.Log("Index of this GameObject: " + index);
                }
                else
                {
                    Debug.LogError("This GameObject is not in the array!");
                }
            }
            else
            {
                Debug.LogError("YourOtherScript is not found on the cat GameObject!");
            }
        }
    }
}
