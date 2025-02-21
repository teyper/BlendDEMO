using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecont : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        float y;
        float x;
        y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        animator.SetFloat("head", x);
        animator.SetFloat("Speed", y);
        
    }
}
