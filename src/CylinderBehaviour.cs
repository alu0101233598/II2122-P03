using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderBehaviour : MonoBehaviour
{
    private GameObject player;
    public bool isTypeA, isTypeB;
    public static float minimumDistance = 7f;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (!player) Debug.LogError("Player not found! D:");
    }

    private void Start()
    {
        if (isTypeB) GameManager.instance.proximityEvent += changeColor;
    }

    void Update()
    {
        if (isTypeA)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance < minimumDistance)
            {
                GameManager.instance.triggerProximity(distance);
            }
        }
    }

    private void changeColor(float distance)
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Color.HSVToRGB(distance / minimumDistance, 0.73f, 0.96f);
    }
}