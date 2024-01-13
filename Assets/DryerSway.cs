using System;
using UnityEngine;

public class DryerSway : MonoBehaviour
{
    [Header("Sway settings")]
    [SerializeField] private float smooth;
    [SerializeField] private float multiplier;

    // Update is called once per frame
    void Update()
    {
        //mouse input
        float mousex=Input.GetAxisRaw("Horizontal")*multiplier;
        float mousey=Input.GetAxisRaw("Vertical")*multiplier;
        //target rotation
        Quaternion rotationx=Quaternion.AngleAxis(-mousey,Vector3.right);
        Quaternion rotationy=Quaternion.AngleAxis(mousex,Vector3.up);
        Quaternion targetRotate=rotationx*rotationy;
        //rotate
        transform.localRotation=Quaternion.Slerp(transform.localRotation, targetRotate, smooth*Time.deltaTime);
    }
}
