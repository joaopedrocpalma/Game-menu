using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsText : MonoBehaviour
{
    public GameObject Text;
    public GameObject Text2;

    public void showText()
    {
        if(Text != null)
        {
            Text.SetActive(true);
        }
        if (Text2 != null)
        {
            Text2.SetActive(false);
        }

    }
}
