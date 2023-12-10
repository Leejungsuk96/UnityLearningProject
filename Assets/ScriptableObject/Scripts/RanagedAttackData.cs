using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RangedAttackData", menuName = "TopDOwnCOntroller/Attack/Ranged", order = 1)]

public class RanagedAttackData : AttackSO
{
    [Header("Ranged Attack Data")]
    public string bullerNameTag;
    public float duration;
    public float spreed;
    public float numberofProjectilesPerShot;
    public float multipleProjectilesAngle;
    public Color projectileColor;
}
