using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidePlaneController : MonoBehaviour
{
    [SerializeField] GameObject video;

    Animation m_animation;
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animation = video.GetComponent<Animation>();
        m_animator = video.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnImageTracked(){
        m_animator.SetTrigger("moveup");
    }
    
    public void OnImageLostTracked(){
        m_animator.SetTrigger("idle");
    }
}
