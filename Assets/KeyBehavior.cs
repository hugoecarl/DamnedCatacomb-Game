﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    public float rotation_speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f,0.0f,rotation_speed);
    }
}
