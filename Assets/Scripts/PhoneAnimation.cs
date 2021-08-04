using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneAnimation : MonoBehaviour
{
    [SerializeField] GameObject phone;

    Animation m_animation;
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animation = phone.GetComponent<Animation>();
        m_animator = phone.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovePhone(){
        m_animator.SetTrigger("phonemoveright");
    }
    
    public void OnImageLostTracked(){
        m_animator.SetTrigger("phoneidle");
    }


}
