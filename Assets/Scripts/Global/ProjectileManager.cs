using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem _impactParticleSystem;

    public static ProjectileManager instance;
    [SerializeField] private GameObject testObj;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShootBullet(Vector2 startPosition, Vector2 direction, RangedAttackData attackData)
    {
        //�ӽ�
        GameObject obj = Instantiate(testObj);

        obj.transform.position = startPosition;
        RangaedAttackController attackController = obj.GetComponent<RangaedAttackController>();
        attackController.InitializeAttack(direction, attackData, this);
        obj.SetActive(true);
    }
  
}
