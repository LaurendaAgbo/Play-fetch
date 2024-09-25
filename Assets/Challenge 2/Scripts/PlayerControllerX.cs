using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastFired;

    // Update is called once per frame
    void LateUpdate()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if ((lastFired - Time.time) < -1)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastFired = Time.time;
            }
        }
    }
}
