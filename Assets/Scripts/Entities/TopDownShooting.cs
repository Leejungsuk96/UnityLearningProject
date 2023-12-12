using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownShooting : MonoBehaviour
{
    private ProjectileManager _projectileManager;
    private TopDownCharacterController _controller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 _aimDirection = Vector2.right;

    public AudioClip shootingClip;

    // Start is called before the first frame update

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }
    void Start()
    {
        _projectileManager = ProjectileManager.instance;
        _controller.OnAttackEvent += OnShoot;
        _controller.OnLookEnvent += OnAim;
    }

    private void OnShoot(AttackSO attackSO)
    {
        RangedAttackData rangedAttackData= attackSO as RangedAttackData;
        float projectilesAngleSpace = rangedAttackData.multipleProjectilesAngel;
        int numberOfProjectilesPerShot = rangedAttackData.numberofProjectilesPerShot;
        float minAngle = -(numberOfProjectilesPerShot / 2f) * projectilesAngleSpace + 0.5f * rangedAttackData.multipleProjectilesAngel;

        for( int i = 0; i < numberOfProjectilesPerShot; i++ )
        {
            float angle = minAngle + projectilesAngleSpace * i;
            float randomSPread = Random.Range(rangedAttackData.spread, rangedAttackData.spread);
            angle += randomSPread;
            CreatProjectile(rangedAttackData, angle);
        }
        
    }

    private void CreatProjectile(RangedAttackData rangedAttackData, float angle)
    {
        //юс╫ц
        _projectileManager.ShootBullet(projectileSpawnPosition.position, RotateVector2(_aimDirection, angle), rangedAttackData);

        if (shootingClip)
            SoundManager.PlayClip(shootingClip);
    }

    private static Vector2 RotateVector2(Vector2 v, float degree)
    {
        return Quaternion.Euler(0, 0, degree) * v;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        _aimDirection = newAimDirection;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
