using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorseBehaviour : MonoBehaviour
{
    public Text horseText;
    public bool isHorseA, isHorseB;

    void Start()
    {
        if (isHorseA)
        {
            GameManager.instance.collisionBEvent += changeText;
            horseText.text = "";
        }
        else if (isHorseB)
        {
            GameManager.instance.collisionAEvent += changeForce;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (isHorseB) GameManager.instance.horseBCollision();
            else if (isHorseA) GameManager.instance.horseACollision();
        }
    }

    private void changeText()
    {
        if (isHorseA)
        {
            horseText.text = (horseText.text == "") ? "hiiiiiiii!" : "";
        }
    }

    private void changeForce()
    {
        RepelBehaviour rb = GetComponent<RepelBehaviour>();
        rb.repelSpeed *= 2;
        Debug.Log("New repel speed: " + rb.repelSpeed);
    }
}
