using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextUpdate : MonoBehaviour
{

    public Text timesLeftText   = null;
    public Text totalTriesText  = null;
    public Text totalScoreText  = null;


    public void UpdateText()
    {

        timesLeftText.text  = $"���� �ð�: {GameManager.instance.time}";
        totalTriesText.text = $"�õ� Ƚ��: {GameManager.instance.tryCount}";
        totalScoreText.text = $"�� ����: {GameManager.instance.score}";

    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

}
