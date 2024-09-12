using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    [Header("Number of lives")]
    [SerializeField] int maxNbOfLives = 9;
    [SerializeField] int currentLives;

    [Header("Controllers")]
    [SerializeField] GameObject controllerR ;
    [SerializeField] GameObject controllerL;
    [SerializeField] GameObject head;
    BodyCollision collisionCR;
    BodyCollision collisionCL;
    BodyCollision collisionH;
    [SerializeField] bool goodCR;
    [SerializeField] bool goodCL;
    [SerializeField] bool goodH;

    void OnEnable(){
        currentLives = maxNbOfLives;
        collisionCR = controllerR.GetComponent<BodyCollision>();
        collisionCL = controllerL.GetComponent<BodyCollision>();
        collisionH = head.GetComponent<BodyCollision>();
    }




    void Update()
    {
        goodCR = collisionCR.goodPlacementCR;
        goodCL = collisionCL.goodPlacementCL;
        goodH = collisionH.goodPlacementH;

        Debug.Log(currentLives/3);
    }

    public void CheckDamage()
    {
        if (goodCR && goodCL && goodH) {
            Debug.Log("yay!");
            }
        else 
        {
            currentLives --;
        }
        // collisionCR.goodPlacementCR = false;
        // collisionCL.goodPlacementCL = false;
        // collisionH.goodPlacementH = false;
    }

}
