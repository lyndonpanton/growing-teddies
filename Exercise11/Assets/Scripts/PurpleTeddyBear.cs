using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script for the Purple Teddy Bear unity sprite
/// </summary>

public class PurpleTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;

        newScale.x *= 3;

        transform.localScale = newScale;
    }
}
