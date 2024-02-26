using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float interval = 3.0f; // �ݺ� ����(��)
    private float nextPlayTime;

    void Start()
    {
        nextPlayTime = Time.time + interval;
    }

    void Update()
    {
        if (Time.time >= nextPlayTime)
        {
            particleSystem.Play();
            nextPlayTime = Time.time + interval;
        }
    }
}
