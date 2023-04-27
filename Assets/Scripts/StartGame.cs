using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject _suka;

    public void AAA(int a)
    {
        StartCoroutine(Some(a));
    }

    private IEnumerator Some(int a)
    {
        print("hey");
        _suka.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(a);
        StopCoroutine(Some(a));
    }

}
