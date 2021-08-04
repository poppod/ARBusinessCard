using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailAnimation : MonoBehaviour
{
    [SerializeField] GameObject mail;

    Animation m_animation;
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animation = mail.GetComponent<Animation>();
        m_animator = mail.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveMail(){
        m_animator.SetTrigger("mailmoveright");
    }
    
    public void OnImageLostTracked(){
        m_animator.SetTrigger("mailidle");
    }




}
