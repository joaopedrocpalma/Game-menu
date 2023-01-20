using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Panel3;

    public void openPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
        if (Panel2 != null)
        {
            Panel2.SetActive(false);
        }
        if (Panel3 != null)
        {
            Panel3.SetActive(false);
        }
    }
}
