using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor001A : MonoBehaviour
{
    public GameObject moveableWall;
    void OnTriggerEnter(Collider other)
    {
        moveableWall.GetComponent<Animator>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
