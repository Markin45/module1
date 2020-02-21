using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponentInParent<Character>();
    }

    void Attack_Bat()
    {
        character.DoDamageToTarget();
        SoundControler.Instance.Go(SoundControler.Sound.StandartHit);
    }
    void Attack_fist()
    {
        character.DoDamageToTarget();
        SoundControler.Instance.Go(SoundControler.Sound.HandHit);
    }

    void AttackEnd()
    {
        character.SetState(Character.State.RunningFromEnemy);
    }

    void Shoot()
    {
        character.DoDamageToTarget();
    }

    void ShootEnd()
    {
        character.SetState(Character.State.Idle);
    }

    void Boom()
    {
        ParticleSystem hitEffect = GetComponentInChildren<ParticleSystem>();
        hitEffect.Play();
        SoundControler.Instance.Go(SoundControler.Sound.ShootHit);
    }

}
