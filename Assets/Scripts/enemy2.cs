using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    private float pInput;
    private Rigidbody rb;
    private Transform enemyTransform;
    private Vector3 userRot;
    public GameObject player;
    private Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        enemyTransform = rb.GetComponent<Transform>();
        playerPos = player.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(playerPos - enemyTransform.position);
        enemyTransform.rotation = Quaternion.Lerp(enemyTransform.rotation, targetRotation, 1f);

    }

    void FixedUpdate()
    {
            rb.velocity = enemyTransform.forward * 0.4f;
        

    }
}
