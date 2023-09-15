using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] private float scoreScale;

    private float score;

    void Update()
    {
        score += scoreScale * Time.deltaTime;

        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
}
