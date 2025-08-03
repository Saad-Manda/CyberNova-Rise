using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1.5f;
    [SerializeField] AudioClip CrashSFX;
    [SerializeField] AudioClip SuccessSFX;
    [SerializeField] ParticleSystem SuccessParticles;
    [SerializeField] ParticleSystem CrashParticles;

    AudioSource audioSource;

    bool isControllable = true;
    //bool isCollidable = true;

    void Start()
    {
        audioSource =   GetComponent<AudioSource>();
    }

    void Update()
    {
        RespondToDebugKeys();
    }

    void RespondToDebugKeys()
    {
        if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            LoadNextLevel();
        }
        // else if (Keyboard.current.cKey.wasPressedThisFrame)
        // {
        //     isCollidable = !isCollidable;
        // }
    }

    void OnCollisionEnter(Collision other)
    {
        if (!isControllable/* || !isCollidable*/) return;
        
        switch (other.gameObject.tag)   
        {
            case "Friendly":
                Debug.Log("You can rest here, but its just only Start!");
                break;

            case "Fuel":
                Debug.Log("It's just the fuel");
                break;

            case "Finish":
                ṢtartSuccessSequence();
                break;

            default:
                StartCrashSequence();
                break;
        }
    }


    void ṢtartSuccessSequence()
    {
        isControllable = false;
        audioSource.Stop();
        audioSource.PlayOneShot(SuccessSFX);
        SuccessParticles.Play();
        GetComponent<Movement>().enabled = false;
        Invoke("LoadNextLevel", levelLoadDelay);
    }

    void StartCrashSequence()
    {
        isControllable = false;
        audioSource.Stop();
        audioSource.PlayOneShot(CrashSFX);
        CrashParticles.Play();
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);
    }

    void ReloadLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    void LoadNextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;

        if (nextScene == SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 0;
        }

        SceneManager.LoadScene(nextScene);
    }
}
