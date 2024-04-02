using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    private AudioSource audioSource;
    [SerializeField] private Slider sliderMusique;
    [SerializeField] private Slider sliderFX;
    // Start is called before the first frame update
    void Start()
    {
        audioMixer = GetComponent<AudioMixer>();
        
    }

    public void AjusterVolume(float volume){
        audioMixer.SetFloat("VolumeAmbiance", ConvertToLog(volume));
    }

    private float ConvertToLog(float volume){
        return Mathf.Log10(volume) * 20;
    }

    public void VolumeFX(float volumeFX){
        audioMixer.SetFloat("VolumeFX", ConvertToLog(volumeFX));
        audioSource.Play();
    }

    private float ConvertToLogarithme(float volumeFX){
        return Mathf.Log10(volumeFX) * 20;
    }
}
