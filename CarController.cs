using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void MoveCar()
    {
        speed = 5f;
    }

    public void StopCar()
    {
        speed = 0f;
    }
}

