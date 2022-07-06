using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.transform.position = transform.position + Vector3.left;
            Destroy(gameObject.GetComponent<CollectManager>());
            other.gameObject.AddComponent<CollectManager>();
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.tag = "Collected";
            other.gameObject.AddComponent<DolarMovment>();
            other.gameObject.GetComponent<DolarMovment>().connectedDolar = transform;
        }
    }
}
