using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeBehaviour : MonoBehaviour
{
    private GameObject player;
    private Renderer render;
    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        render = GetComponent<Renderer>();
    }

    private void Start()
    {
        GameManager.instance.proximityEvent += rotate;
    }

    void rotate(float distance)
    {
        if (!render.enabled)
        {
            render.enabled = true;
            GameManager.instance.spook();
        }
        transform.LookAt(player.transform.position);
        Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
    }
}
