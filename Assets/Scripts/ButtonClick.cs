using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;

    public static bool isClickOn = true;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        //print(isClickOn + " «ƒ¿–Œ¬¿ ¡Àﬂ“‹");
    }

    private void Update()
    {
        if (!isClickOn)
        {
            _audioSource.mute = true;
        }
        else
        {
            _audioSource.mute = false;
        }
    }

    public void MakeSound()
    {
        _audioSource.PlayOneShot(_clip);
    }

    public void MusicStateChange()
    {
        isClickOn = !isClickOn;
    }
}
