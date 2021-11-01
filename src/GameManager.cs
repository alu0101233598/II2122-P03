using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void CollisionDelegate();
public delegate void ProximityDelegate(float distance);

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public event CollisionDelegate collisionAEvent;
    public event CollisionDelegate collisionBEvent;
    public event ProximityDelegate proximityEvent;

    void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
    }

    public void horseACollision()
    {
        collisionAEvent();
    }

    public void horseBCollision()
    {
        collisionBEvent();
    }

    public void triggerProximity(float distance)
    {
        proximityEvent(distance);
    }

    public void spook()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
