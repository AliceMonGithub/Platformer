using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;

    private void Update()
    {
        transform.position = _target.position + _offset;
    }
} 
