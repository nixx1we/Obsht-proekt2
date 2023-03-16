using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] public float speed = 8f;
    [SerializeField] private Rigidbody rb;

    private void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        rb.velocity = dir * speed;

         
    }
}
