using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distance_from_target;
    public float to_target;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hit))
        {
            to_target = hit.distance;
            distance_from_target =  hit.distance;
        }
    }
}
