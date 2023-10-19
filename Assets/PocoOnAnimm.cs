using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocoOnAnimm : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        //PlayAnim();
    }
    public void PlayAnim()
    {
        anim.SetTrigger("Play");
    }
}
