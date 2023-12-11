using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem _impactParticleSystem;

    public static ProjectileManager instance;

    private ObjectPool objectPool;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        objectPool = GetComponent<ObjectPool>();
    }

    public void ShootBullet(Vector2 startPosition, Vector2 direction, RangedAttackData attackData)
    {
        //�ӽ�
        GameObject obj = objectPool.SpawnFromPool(attackData.bulletNameTag);

        obj.transform.position = startPosition;
        RangaedAttackController attackController = obj.GetComponent<RangaedAttackController>();
        attackController.InitializeAttack(direction, attackData, this);
        obj.SetActive(true);
    }
  
}
