using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DolarMovment : MonoBehaviour
{
    public Transform connectedDolar;
    void Update()
    {
        transform.position = new Vector3(
            connectedDolar.position.x - 1,
            connectedDolar.position.y,
            Mathf.Lerp(transform.position.z, connectedDolar.position.z, Time.deltaTime*20f)
            );
    }
}
