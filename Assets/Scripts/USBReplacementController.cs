using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class USBReplacementController : MonoBehaviour
{
    
    public Shader ReplacementShader;
    // DON'T WORK IN URP !!
    void OnEnable()
    {
        Debug.Log("Enabled");
        if (ReplacementShader != null) {
            // the camera will replace all the shaders in the scene with  
            // the replacement one the “RenderType” configuration must match
            // in both shader
            GetComponent<Camera>().SetReplacementShader( ReplacementShader, "RenderType");
        }
    }

    void OnDisable() {
        Debug.Log("Disabled");
        GetComponent<Camera>().ResetReplacementShader();
    }
}
