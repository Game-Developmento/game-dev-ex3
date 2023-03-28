using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// useful source: https://docs.unity3d.com/ScriptReference/Renderer-enabled.html
// https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html

public class ToggleHide : MonoBehaviour
{
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) { // another option: GetKeyUp will change only when the button is released
            rend.enabled = !rend.enabled;
        }
    }
}
