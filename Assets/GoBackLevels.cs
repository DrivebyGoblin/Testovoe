using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackLevels : MonoBehaviour
{
    [SerializeField] private Animator _wrapper2;
    [SerializeField] private Animator _wrapper1;
    

    private IEnumerator Blyad()
    {
        wrap2GoUp();
        yield return new WaitForSeconds(0.6f);
        _wrapper1.Play("FirstGoBack");
        StopCoroutine(Blyad());
    }

    public void Zapuskaem()
    {
        StartCoroutine(Blyad());
    }

    public void wrap2GoUp()
    {
        _wrapper2.SetBool("is", true); 
    }


}
