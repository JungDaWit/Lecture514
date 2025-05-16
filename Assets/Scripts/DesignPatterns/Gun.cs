using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public abstract class Wepon : MonoBehaviour
//{
//    public abstract void Attack();
//}
public class Gun : MonoBehaviour
{
    [SerializeField] private LayerMask targetLayer;
    [SerializeField][Range(0, 100)] private float attackRange;
    [SerializeField] private int shootDamage;
    [SerializeField] private float shootDelay;
    [SerializeField] private AudioClip shootSFX;

    private CinemachineImpulseSource impulse;
    private Camera camera;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        camera = Camera.main;
    }
    private void RayShoot()
    {
        Ray ray = new Ray
    }
    private void PlayShootSound()
    {
        SFXController sfx = GameManager.Instance.Audio.GetSFX();
        sfx.play(shootSFX);
    }
    private void PlayCameraEffect()
    {

    }
    private void PlayShootEffect()
    {

    }
}
