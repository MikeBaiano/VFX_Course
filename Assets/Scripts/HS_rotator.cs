using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HS_rotator : MonoBehaviour
{
    [SerializeField] private float ySpeed = 0f;
    [SerializeField] private float xSpeed = 0f;
    [SerializeField] private float zSpeed = 0f;

    void OnEnable() => InvokeRepeating(nameof(Rotate), 0, 0.01f);
    void OnDisable() => CancelInvoke(nameof(Rotate));

    void Rotate() => this.transform.Rotate(xSpeed, ySpeed, zSpeed);
}
