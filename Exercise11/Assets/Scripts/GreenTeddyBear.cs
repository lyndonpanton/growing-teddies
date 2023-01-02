using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script for the Green Teddy Bear unity sprite
/// </summary>

public class GreenTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;

        newScale.y *= 3;

        transform.localScale = newScale;
    }
}
