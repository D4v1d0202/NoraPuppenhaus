using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    //private bool isInMenu = false;

    void Start(){
        if(!PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else{
            Load();
        }
    }

    /*void Update(){
        if(SceneManager.GetActiveScene().buildIndex != 19) //Settings?
            CheckMenu();
    }

    private void CheckMenu(){
        if(!isInMenu){
            if(Input.GetKeyUp(KeyCode.Escape)){
                isInMenu = true;
                volumeSlider.interactable = true;
            }
            }
        else{
            if(Input.GetKeyUp(KeyCode.Escape)){
            isInMenu = false;
            volumeSlider.interactable = false;
            }
    }
    }*/

    public void ChangeVolume(){
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load(){
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save(){
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
