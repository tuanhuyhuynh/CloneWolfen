using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKeyA : MonoBehaviour
{
    public GameObject keyUI;
    public GameObject lockedTrigger;
    public GameObject lockedTrigger2;
    public GameObject theKey;

    void OnTriggerEnter(Collider other)
    {
        keyUI.SetActive(true);
        lockedTrigger.SetActive(true);
        lockedTrigger2.SetActive(true);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        theKey.SetActive(false);
    }
}
