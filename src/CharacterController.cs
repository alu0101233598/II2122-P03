using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float translationSpeed = 5f;
    public float rotationSpeed = 100f;
    
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        float upMove = Input.GetAxis("Up");
        transform.Translate(new Vector3(horizontalMove, 0f, verticalMove) * translationSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0f, upMove, 0f) * rotationSpeed * Time.deltaTime);
    }
}