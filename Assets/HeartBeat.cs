using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat : MonoBehaviour
{
    [SerializeField] public float minScale = 0.5f;
    [SerializeField] public float maxScale = 2f;
    [SerializeField] public float beatSpeed = 2f;

    private float currentScale;
    private float timer;

    private void Start()
    {
        currentScale = transform.localScale.x;
    }

    private void Update()
    {
        timer += Time.deltaTime * beatSpeed;

        float sin = Mathf.Sin(timer);
        float sinNorm = (sin/2.0f) + 0.5f;
        float lerp = Mathf.Lerp(minScale, maxScale, sinNorm);
        transform.localScale = Vector3.one * lerp;
    }
}
