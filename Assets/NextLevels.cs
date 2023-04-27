using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevels : MonoBehaviour
{
    public Animator _nextLevels;
    public Animator _currentLevels;
    public Animator[] Cloud;

    

    public void StartCor()
    {
        StartCoroutine(BigCorutine());
    }

    private IEnumerator BigCorutine()
    {
        CloudsOff();
        yield return new WaitForSeconds(1.3f);
        DownCurrentMenu();
        yield return new WaitForSeconds(0.5f);
        ShowNewMenu();

    }

    public void ShowNewMenu()
    {
        _nextLevels.enabled = true;
    }

    public void DownCurrentMenu()
    {
        _currentLevels.enabled = true;
    }

    public void CloudsOff()
    {
        for (int i = 0; i < Cloud.Length; i++)
        {
            Cloud[i].enabled = true;
            Cloud[i].Play("clouds");

        }
    }
}
