using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerRB : MonoBehaviour
{
    public float translationSpeed = 5f;
    public float rotationSpeed = 100f;
    
    private Rigidbody rb;

    void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 mInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        rb.MovePosition(rb.position + mInput * Time.deltaTime * translationSpeed);
        if (Input.GetKeyDown("e"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 15f, rb.velocity.z);
        }
    }
}