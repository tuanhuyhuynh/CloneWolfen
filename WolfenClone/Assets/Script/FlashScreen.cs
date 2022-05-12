using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitShowScreen());
    }

    IEnumerator WaitShowScreen()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}
