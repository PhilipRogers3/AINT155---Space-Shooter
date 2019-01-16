using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class EnemyDetection : MonoBehaviour
{
    public UnityEvent onDetectPlayer;


    void OnTriggerEnter2D(Collider2D other)
    {
        onDetectPlayer.Invoke();
    }
}
