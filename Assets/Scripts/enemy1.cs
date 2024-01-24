using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy1 : MonoBehaviour
{
    private float pInput;
    private Rigidbody rb;
    private Transform playerTransform;
    private Vector3 userRot;
    private float userRotInput;
    private float timer = 0f;
    System.Random rand = new System.Random();


    private bool jumped = false;
    private bool moved = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerTransform = rb.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f && !moved)
        {
            ChangeDirection();
            moved = true;
        }

        if (timer > 4.5f)
        {
            moved = false;
            timer = 0f;
        }
    }

    void ChangeDirection()
    {
        userRot = playerTransform.rotation.eulerAngles;
        userRot += new Vector3(0, rand.Next(360), 0);
        playerTransform.rotation = Quaternion.Euler(userRot);
    }

    void FixedUpdate()
    {
        if (moved)
        {
            rb.velocity += playerTransform.forward * 0.1f;
        }

    }
}
