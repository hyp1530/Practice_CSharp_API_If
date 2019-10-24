using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Animator m_Animator;

    // Use this for initialization
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            m_Animator.SetTrigger("吃飯觸發器");
        }
        m_Animator.SetBool("跑步開關", Input.GetKey(KeyCode.R));
    }
}
