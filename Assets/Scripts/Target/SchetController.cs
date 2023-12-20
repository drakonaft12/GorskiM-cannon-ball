using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SchetController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private int schetBase;
    void Start()
    {
        text.text = "0";
    }

    public void AddSchet(int schet)
    {
        schetBase += schet;
        text.text = schetBase.ToString();
    }

    
}
