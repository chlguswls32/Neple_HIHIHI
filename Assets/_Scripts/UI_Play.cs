using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Play : MonoBehaviour
{
    public Button pauseButton;
    public UiPauseDlg pauseDlg;

    public void PauseButton()
    {
        pauseDlg.Open();
    }

    private void Awake()
    {
        pauseDlg.Close();
    }
}
