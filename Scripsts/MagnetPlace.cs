using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetPlace : MonoBehaviour
{
    bool isInzone = false;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject magnetPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.gameObject.CompareTag("magnetic") && !isInzone)
        {
            isInzone = true;
            other.transform.parent = magnetPoint.transform;
            other.transform.position = magnetPoint.transform.position;
            rb.velocity = Vector3.zero;
            rb.useGravity = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isInzone = false;
        other.transform.parent = null;
        rb.useGravity = false;
    }
}
