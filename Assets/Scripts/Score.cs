using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    [SerializeField] float _score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ScoreShot()
    {
        _score++;
        _scoreText.text = _score.ToString();

    }
        
   }
