using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource AmmoPickupSound;
    public GameObject pickUpDisplay;

    void OnTriggerEnter(Collider other)
    {
        
        fakeAmmoClip.SetActive(false);
        AmmoPickupSound.Play();
        GlobalAmmo.handgunAmmo += 10;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "CLIP OF BULLTETS";
        pickUpDisplay.SetActive(true);
    }
}
