using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameAnimation : MonoBehaviour
{
    [SerializeField] GameObject portraitname;

    Animation m_animation;
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animation = portraitname.GetComponent<Animation>();
        m_animator = portraitname.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnImageTracked(){
        m_animator.SetTrigger("namemoveright");
    }
    
    public void OnImageLostTracked(){
        m_animator.SetTrigger("nameidle");
    }


}
