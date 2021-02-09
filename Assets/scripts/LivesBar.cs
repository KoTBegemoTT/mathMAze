using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesBar : MonoBehaviour
{
    public Transform[] hearts = new Transform[9];

    private void Awake()
    {
        for(int i = 0; i < hearts.Length; i++)
        {
            hearts[i] = gameObject.transform.GetChild(i);
        }
    }

    public void Refresh()
    {
        if (variable.lives == 0)
            GameOver();
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < variable.lives)
            {
                hearts[i].gameObject.SetActive(true);
            }
            else
                hearts[i].gameObject.SetActive(false);
        }
    }

    public void GameOver()
    {
        Application.LoadLevel(2);
    }
}
