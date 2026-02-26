using UnityEngine;

public class EnemySFXManager : MonoBehaviour
{
    //all sound effects related to player and player input
    public AudioSource EnemySFXPlayer;
    public AudioClip thiefProwlSFX, mouseProwlSFX, GrandmaProwlSFX, ahaSFX;
    //replace method names and make references in related scripts (enemy firing, boss stuff, etc)
    public void PlayThiefProwl()
    {
        EnemySFXPlayer.PlayOneShot(thiefProwlSFX);
        Debug.Log("ThiefProwlingSFX Played");
    }

    public void PlayMouseProwl()
    {
        EnemySFXPlayer.PlayOneShot(mouseProwlSFX);
        Debug.Log("MouseProwlSFX Played");
    }

    public void PlayGrandmaProwl()
    {
        EnemySFXPlayer.PlayOneShot(GrandmaProwlSFX);
        Debug.Log("GrandmaProwlSFX Played");
    }

    public void PlayAhaSound()
    {
        EnemySFXPlayer.PlayOneShot(ahaSFX);
        Debug.Log("AhaSFX Played");
    }
    
}

