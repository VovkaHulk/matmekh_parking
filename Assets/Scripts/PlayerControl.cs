using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    CarScript car;
    float pressBreak = 0f;
    // Update is called once per frame
    void Update()
    {
        car.throttleInput = Input.GetAxis("Vertical");
        car.stearInput = -Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.Space))
            pressBreak = Math.Min(pressBreak + 0.02f, 1f);
        else
            pressBreak = 0;
        car.brakeInput = pressBreak;
    }
}
