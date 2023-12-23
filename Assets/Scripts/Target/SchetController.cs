using System.Collections;
using System.Collections.Generic;
using TMPro;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SchetController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private int schetBase;
    private float col = 0f;
    void Start()
    {
        text.text = "0";
        RandomColor();
    }


    private void RandomColor()
    {
        text.DOColor(Color.HSVToRGB(col, 1, 0.7f), 0.5f).OnComplete(() => { col += 0.1f; col %= 1f; RandomColor(); });
    }

    public void AddSchet(int schet)
    {
        schetBase += schet;
        text.text = schetBase.ToString();
    }

    
}
