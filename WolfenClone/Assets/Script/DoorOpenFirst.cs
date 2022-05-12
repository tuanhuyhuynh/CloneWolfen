using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{
    public GameObject theDoor;
    public GameObject theCube;
    public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorOpen");
        this.GetComponent<BoxCollider>().enabled = false;
        theCube.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorClose");
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;
        theCube.GetComponent<BoxCollider>().enabled = true;
    }
}
