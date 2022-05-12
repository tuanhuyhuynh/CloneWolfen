using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public AudioSource clickSound;
    public GameObject fadeOut;
    public void NewGame()
    {
        StartCoroutine(NewGameRoutien());
    }
    public void Credits()
    {
        StartCoroutine(CreditsRoutien());
    }

    public void BackAtMenu()
    {
        SceneManager.LoadScene(3);
    }

    IEnumerator NewGameRoutien()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }

    IEnumerator CreditsRoutien()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
