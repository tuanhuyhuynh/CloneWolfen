using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;
    public AudioSource fireSound;
    public bool isFiring= false;
    public float fireRate = 1.5f;
    public int genHurt;
    public AudioSource[] hurtSound;
    public GameObject hurtFlash;
    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;

        }
        if (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire());
        }
        if(hitTag != "Player")
        {
            theSoldier.GetComponent<Animator>().Play("infantry_guard_idle");
            lookingAtPlayer = false;
        }
    }
    IEnumerator EnemyFire()
    {
        isFiring = true;
        
        theSoldier.GetComponent<Animator>().Play("infantry_combat_shoot",-1 ,0);
        theSoldier.GetComponent<Animator>().Play("infantry_combat_shoot");
        fireSound.Play();
        lookingAtPlayer = true;
        GlobalHealth.healthValue -= 5;
        genHurt = Random.Range(0, 3);
        hurtFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        hurtFlash.SetActive(false);
        hurtSound[genHurt].Play();
        yield return new WaitForSeconds(fireRate);
        isFiring = false;
    }
}
