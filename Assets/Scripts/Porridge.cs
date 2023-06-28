using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porridge : MonoBehaviour
{
   [SerializeField] private float temperature;

    private void Start()
    {
        temperature = 100;
    }

    private void Update()
    {
        //100      = 100         - 0.00125
        //99
        //98
        temperature = temperature - Time.deltaTime;
        // Computer running at 800 FPS. DeltaTime... deltaTime will be 1/800 = 0.00125
        // Computer running at 800 FPS. DeltaTime... deltaTime will be 1/60 = 0.01667
        // Computer running at 800 FPS. DeltaTime... deltaTime will be 1/10 = 0.1

        if (temperature > 70)
        {
            Debug.Log("The temperature is too hot  " + (int)temperature);
        }

        else if (temperature < 40)
        {
            Debug.Log("The temperature is too cold  " + (int)temperature);
        }

        else
        {
            Debug.Log("The temperature is just right!  " + (int)temperature);
        }
    }
}
