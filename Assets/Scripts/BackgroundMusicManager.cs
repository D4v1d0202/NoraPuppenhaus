using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    private AudioSource currentMusic;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object has an AudioSource
        AudioSource newMusic = other.GetComponent<AudioSource>();
        if (newMusic != null && newMusic != currentMusic)
        {
            if (currentMusic != null)
                currentMusic.Stop(); // Stop the old music

            currentMusic = newMusic;
            currentMusic.Play();
        }
    }
}
