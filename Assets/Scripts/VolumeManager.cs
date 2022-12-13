using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeManager : MonoBehaviour
{

    [SerializeField] private Slider MusicVolumeSlider = null;

    [SerializeField] private Text MusicVolumeText = null;


    void Start()
    {
        LoadVolumeValues();
    }

    public void VolumeSlider(float volume)
    {
        MusicVolumeText.text = volume.ToString("0.0");
    }
    public void SaveToMenuButton()
    {
        float volumeValue = MusicVolumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadVolumeValues();
        SceneManager.LoadScene("Menu");
    }

    void LoadVolumeValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        MusicVolumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
