using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    void Awake()
    {
        switch (variable.defitedCount)
        {
            case 1:
                variable.Score = 11;
                break;
            case 2:
                variable.Score = 23;
                break;
            case 3:
                variable.Score = 42;
                break;
            case 4:
                variable.Score = 53;
                break;
            case 5:
                variable.Score = 65;
                break;
            case 6:
                variable.Score = 76;
                break;
            case 7:
                variable.Score = 88;
                break;
            case 8:
                variable.Score = 100;
                break;
        }
        gameObject.GetComponent<Text>().text += variable.Score + "% игры";
    }

}
