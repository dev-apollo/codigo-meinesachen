using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound_Control : MonoBehaviour
{
    public AudioSource music;
    public AudioSource sfx;
    private float musicVol = 1f;
    private float sfxVol = 1f;
    void Update()
    {
        music.volume = musicVol;
        sfx.volume = sfxVol;
    }
    public void updateMusicVol(float volume){
        musicVol = volume;
    }
    public void updateSfxVol(float volume){
        sfxVol = volume;
    }
    public void quitGame(){
        Application.Quit();
    }
}
