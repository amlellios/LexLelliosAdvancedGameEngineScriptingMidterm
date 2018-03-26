

using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    private int spinx = 0;
    private int spiny = 7;
    private int spinz = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinx, spiny, spinz);
    }
}