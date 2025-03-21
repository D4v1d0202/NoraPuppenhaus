using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabDoor : XRSimpleInteractable
{
    private int selectCount = 0; // Track number of selections
    private AudioSource audioSource;

    public AudioClip clipOne;
    public AudioClip clipTwo;
    public AudioClip clipThree;

    protected override void Awake()
    {
        base.Awake();

        // Get or add an AudioSource
        audioSource = GetComponent<AudioSource>(); 
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        // Increase selection count and trigger different actions
        selectCount++;

        switch (selectCount)
        {
            case 1:
                PlaySound(clipOne);
                ActionOne();
                break;
            case 2:
                PlaySound(clipTwo);
                ActionTwo();
                break;
            case 3:
                PlaySound(clipThree);
                ActionThree();
                break;
            case 4:
                Destroy(gameObject);
                break;
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (audioSource && clip)
        {
            audioSource.Stop();
            audioSource.clip = clip;
            audioSource.Play();
        }
    }

    private void ActionOne()
    {
        Debug.Log("First action triggered!");
        // Add your custom logic for the first interaction
    }

    private void ActionTwo()
    {
        Debug.Log("Second action triggered!");
        // Add your custom logic for the second interaction
    }

    private void ActionThree()
    {
        Debug.Log("Third action triggered!");
        // Add your custom logic for the third interaction
    }
}
