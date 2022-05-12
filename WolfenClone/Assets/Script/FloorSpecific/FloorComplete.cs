using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FloorComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;

    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(CompleteFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        //StartCoroutine(WaitForMainMenuScene());
    }

    IEnumerator CompleteFloor()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        completePanel.SetActive(true);
    }
    //own create
    IEnumerator WaitForMainMenuScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
    }
}
