using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleManager : MonoBehaviour
{
    private Action OnTimeScaleChanged;
    public float TimeScale = 1f;
    //private void OnValidate()
    //{ 
    //    OnTimeScaleChanged?.Invoke();
    //    Debug.Log("On validate");
    //}
    //private void Start()
    //{
    //    OnTimeScaleChanged += ChangeTimeScale;
    //}
    //private void ChangeTimeScale()
    //{
    //    try {
    //        Time.timeScale = TimeScale;
    //        Debug.Log("AAA");
    //    }
    //    catch { }
    //}
    private void Update()
    {
        Time.timeScale = TimeScale;
    }
}
