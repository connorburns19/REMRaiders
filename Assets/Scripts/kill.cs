using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    [Header("References")]
    [SerializeField] dryerData testdryData;
    public void Start()
    {
        playerShoot.shootInput+=Shoot;
    }
    // Start is called before the first frame update
    public void Shoot()
    {
        Debug.Log("shot");
    }
}
