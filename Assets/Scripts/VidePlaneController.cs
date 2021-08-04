using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidePlaneController : MonoBehaviour
{
    [SerializeField] GameObject videoPlane;
    Animation m_animation;
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animation = videoPlane.GetComponent<Animation>();
        m_animator = videoPlane.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnImageTracked(){
        m_animator.SetTrigger("moveup");
    }
    
    public void OnImageLostTracked(){
        VideoPlaneLocation();
        m_animator.SetTrigger("idle");
    }

    public void VideoPlaneLocation(){
        videoPlane.transform.localRotation = Quaternion.identity;
        videoPlane.transform.localPosition = new Vector3(0.0f, -0.5f, 0.0f);
    }
}
