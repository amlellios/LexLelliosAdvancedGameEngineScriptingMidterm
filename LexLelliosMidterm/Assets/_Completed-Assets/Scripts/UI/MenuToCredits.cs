using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuToCredits : MonoBehaviour
{

    public void ButtonClicked()
    {
        // Load the next scene.
        SceneManager.LoadScene("Credits");
    }
}