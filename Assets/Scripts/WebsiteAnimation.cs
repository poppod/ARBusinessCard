using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebsiteAnimation : MonoBehaviour
{
    [SerializeField] GameObject website;

    Animation m_animation;
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animation = website.GetComponent<Animation>();
        m_animator = website.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnImageTracked(){
        m_animator.SetTrigger("websitemovedown");
    }
    
    public void OnImageLostTracked(){
        m_animator.SetTrigger("websiteidle");
    }


}
