using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float Value;

    public void UpdateValue(float floatInput)
    {
        Value += floatInput;
    }

    public void UpdateValue(FloatData dataObj)
    {
        Value += dataObj.Value;
    }
    
}
