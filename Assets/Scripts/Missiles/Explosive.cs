﻿using UnityEngine;
using System.Collections;

public class Explosive : MonoBehaviour
{

    public float affectRadius = 0;
    public float maxDamage = 0;

    void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }

    void explode()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, affectRadius);
        foreach (Collider col in colls)
        {
            float distance = Vector3.Distance(col.transform.position, transform.position);
            float damage = maxDamage - (maxDamage * (distance / affectRadius));
            col.SendMessage("applyDamage", damage, SendMessageOptions.DontRequireReceiver);
            //Debug.Log("Splodin!");
        }
    }

    public float getExplosionRadius()
    {
        return affectRadius;
    }
}