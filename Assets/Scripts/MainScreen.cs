using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    public InputField Username;
    public void clickSave()
    {
        PlayerPrefs.SetString("username", Username.text);
        SceneManager.LoadScene("Asteroids");
    }
}
