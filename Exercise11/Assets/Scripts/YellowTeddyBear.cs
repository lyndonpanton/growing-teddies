using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script for the Yellow Teddy Bear unity sprite
/// </summary>

public class YellowTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;

        newScale.x *= 4;
        newScale.y *= 4;

        transform.localScale = newScale;
    }
}
