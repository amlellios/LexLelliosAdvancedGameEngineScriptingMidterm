﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuToMenu : MonoBehaviour
{

    public void StartButtonClicked()
    {
        // Load the next scene.
        SceneManager.LoadScene("MenuStart");
    }
}
