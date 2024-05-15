using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestText : MonoBehaviour
{
    private int points;
    public TMP_Text text;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            points++;
            Debug.Log(points);
            text.text = points.ToString();
        }
    }
}
