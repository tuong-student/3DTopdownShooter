using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PlayerScripts : MonoBehaviour
{
    #region Components
    PlayerAnimation animationScripts;
    PlayerOncollision oncollisionScripts;
    PlayerMovement movementScripts;
    #endregion

    private void Awake()
    {
#if UNITY_EDITOR
        GetComponentsIfNeed();
#else

#endif
    }

    private void Update()
    {
#if UNITY_EDITOR
#else
#endif
    }

    void GetComponentsIfNeed()
    {
        animationScripts = GetComponent<PlayerAnimation>();
        oncollisionScripts = GetComponent<PlayerOncollision>();
        movementScripts = GetComponent<PlayerMovement>();

        if(animationScripts == null)
        {
            animationScripts = gameObject.AddComponent<PlayerAnimation>();
        }
        if(oncollisionScripts == null)
        {
            oncollisionScripts = gameObject.AddComponent<PlayerOncollision>();
        }
        if(movementScripts == null)
        {
            movementScripts = gameObject.AddComponent<PlayerMovement>();
        }
    }
}
