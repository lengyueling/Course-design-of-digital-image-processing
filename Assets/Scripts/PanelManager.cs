using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PanelManager : MonoBehaviour
{
    public GameObject go;

    public void ShowOrHidePanel()
    {
        if (go.activeInHierarchy)
        {
            go.SetActive(false);
        }
        else
        {
            go.SetActive(true);
        }
    }
}