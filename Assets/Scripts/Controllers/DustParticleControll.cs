using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticleControll : MonoBehaviour
{
    [SerializeField] private bool createDustOnWalk=true;
    [SerializeField] private ParticleSystem dustParticleSystem;

    public void CreateDustParticles()
    {
        if (createDustOnWalk)
        {
            dustParticleSystem.Stop();
            dustParticleSystem.Play();
        }
    }
}
