using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    [SerializeField] private GameObject _uiInterface;
    [SerializeField] private GameObject _settingsPanel;
    [SerializeField] private Animator _animator;
    

    public void OpenPanel()
    {
        _uiInterface.SetActive(false);
        _settingsPanel.SetActive(true);
    }

    public void OpenInterface()
    {
        _settingsPanel.SetActive(false);
        _uiInterface.SetActive(true);
    }
}
