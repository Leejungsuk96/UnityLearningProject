using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RangedAttackData", menuName = "TopDOwnCOntroller/Attack/Ranged", order = 1)]

public class RangedAttackData : AttackSO
{
    [Header("Ranged Attack Data")]
    public string bullerNameTag;
    public float duration;
    public float spread;
    public int numberofProjectilesPerShot;
    public float multipleProjectilesAngle;
    public Color projectileColor;
}
