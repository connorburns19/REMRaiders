using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Dryer", menuName="Weapon/Dryer")]
public class dryerData : ScriptableObject
{
    [Header("Info")]
    public new string name;
    [Header("Shooting")]
    public float damage;
    public float maxDist;
    [Header("Recharge")]
    public int currentHeat;
    public float reloadTime;
    [HideInInspector]
    public int reloading;
}
