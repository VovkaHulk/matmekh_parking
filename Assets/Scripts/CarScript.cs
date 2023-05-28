using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [HideInInspector]
    public float throttleInput = 0f;
    [HideInInspector]
    public float brakeInput = 0f;
    [HideInInspector]
    public float stearInput = 0f;
    [HideInInspector]
    public float kmH = 0f;
    float ms = 0f;
    float maxVel = 120f / 3.6f;
    float maxRot = 120f;
    float goodSpeed = 40f / 3.6f;
    float deltaRot = 60f;
    float rotAngle = 0f;

    [SerializeField]
    AnimationCurve accel;


    private void FixedUpdate()
    {
        ms = rb.velocity.magnitude;
        kmH = 3.6f * ms;
        if (throttleInput != 0f)
            MoveCar();
        if (stearInput != 0f)
        {
            RotateCar();
            Vector2 oldDir = rb.velocity / ms;
            Vector2 newDir = (Vector2)transform.up + oldDir;
            newDir.Normalize();
            rb.velocity = ms * newDir;
        }
        Brakes();
    }

    private void OnGUI()
    {
        GUI.TextField(new Rect(10, 10, 120, 20), kmH + " km/h");
    }

    void MoveCar()
    {
        rb.velocity += accel.Evaluate(ms/maxVel) * throttleInput * (Vector2)transform.up;
    }

    void RotateCar()
    {
        if (ms <= goodSpeed)
            rotAngle = maxRot;
        else
            rotAngle = maxRot - Mathf.Lerp(0f, deltaRot, (ms - goodSpeed) / (maxVel - goodSpeed));
        transform.Rotate(0f, 0f, rotAngle * stearInput * Time.fixedDeltaTime);
    }

    void Brakes()
    {
        rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, Time.deltaTime * brakeInput);
    }
}
