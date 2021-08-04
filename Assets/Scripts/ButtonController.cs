using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ButtonController : MonoBehaviour
{
    
    public void websiteButton(){
        Application.OpenURL("https://www.yvr-group.com/index.php/about-creative/");
    }

    public void phoneButton(){
#if PLATFORM_IOS
    Application.OpenURL("tel://0827900218");
#else
    Application.OpenURL("tel:0827900218");
#endif
    }

    public void mailButton(){
#if PLATFORM_IOS
    Application.OpenURL("mailto://yvr.studio.official@gmail.com");
#else
    Application.OpenURL("googlegmail://co?to={yvr.studio.official@gmail.com}&subject={subject}&body={body}");
#endif
    }
}