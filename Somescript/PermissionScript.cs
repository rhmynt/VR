﻿using UnityEngine;
using UnityEngine.Android;


public class PermissionScript : MonoBehaviour
{
    GameObject dialog = null;
    void Start()
    {
#if PLATFORM_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
#endif
    }
}
