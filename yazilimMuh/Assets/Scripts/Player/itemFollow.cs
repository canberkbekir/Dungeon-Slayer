using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemFollow : MonoBehaviour
{
    [SerializeField] Transform hand;


    private void Awake()
    {
        hand = GameObject.Find("/Player/Orientation/Hand").transform;
    }


    private void Update()
    {
        gameObject.transform.position = hand.position;
        gameObject.transform.rotation = hand.rotation;
    }
}
