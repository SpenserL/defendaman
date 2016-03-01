﻿using UnityEngine;
using System.Collections;
using System;

public class BasicRanged : Projectile
{
    private Vector2 startPos;
    public int maxDistance;

    //projectile speed

    void Start()
    {
        maxDistance = 10;
        startPos = transform.position;
    }

    void Update()
    {
        if (Vector2.Distance(startPos, transform.position) >= maxDistance)
        {
            Destroy(gameObject);
        }
    }
}
