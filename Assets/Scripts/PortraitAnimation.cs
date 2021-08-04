using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitAnimation : MonoBehaviour
{
    [SerializeField] GameObject portrait;

    Animation m_animation;
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animation = portrait.GetComponent<Animation>();
        m_animator = portrait.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnImageTracked(){
        m_animator.SetTrigger("portraitmoveright");
    }
    
    public void OnImageLostTracked(){
        m_animator.SetTrigger("portraitidle");
    }


}
