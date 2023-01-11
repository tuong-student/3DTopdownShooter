using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PlayerOncollision : MonoBehaviour
{
    #region Components
    PlayerScripts playerScripts;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_EDITOR
        playerScripts = GetComponent<PlayerScripts>();
        if(playerScripts == null)
            playerScripts = gameObject.AddComponent<PlayerScripts>();
#else

#endif
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
#else
#endif
    }
}
