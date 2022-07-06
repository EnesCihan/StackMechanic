using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float horspeed;
    float hor;
    void Start()
    {
        
    }


    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(moveSpeed*Time.deltaTime, hor*horspeed*Time.deltaTime, 0));
    }
}
