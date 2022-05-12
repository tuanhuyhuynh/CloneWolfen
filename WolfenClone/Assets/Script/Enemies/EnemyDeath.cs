using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;

    void DamageEnemy (int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if( enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("infantry_guard_death");
            enemyAI.SetActive(false);
            GlobalScore.scoreValue += 100;
            GlobalComplete.enemyCount += 1;
            StartCoroutine(Waiting());
            //theEnemy.SetActive(false);
        }
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1);
        theEnemy.SetActive(false); 
    }
}
