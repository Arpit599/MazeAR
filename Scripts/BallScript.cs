using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject plane;
    public GameObject SpawnPoint;

    private void Update()
    {
        if (transform.position.y < plane.transform.position.y - 10)
            transform.position = SpawnPoint.transform.position;
    }
}
