using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Ball collided with: " + other.transform.name);
        Destroy(gameObject);
    }
}
