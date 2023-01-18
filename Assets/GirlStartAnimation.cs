using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GirlStartAnimation : MonoBehaviour
{
    [SerializeField] float duration=1;
    Animator anim;
    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 0), duration);
        transform.DOMove(new Vector3(0, 0, 0), duration);
        anim = GetComponent<Animator>();
        int n = Random.Range(1, 3);
        Debug.Log("n " + n);
        anim.SetInteger("anim", n);
    }


}
