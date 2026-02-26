using UnityEngine;

public class PlayerSFXManager : MonoBehaviour
{

    //all sound effects related to player and player input
    public AudioSource PlayerSFXPlayer;
    public AudioClip playerFootstepsSFX, igniteFlashLightSFX;

    public void PlayerFootstepsSFX()
    {
        PlayerSFXPlayer.PlayOneShot(playerFootstepsSFX);
        Debug.Log("PlayerSFX Played");
    }

    //incase above causes issues due to looping
    /*public void PlayerFootstepsSFX()
    {
        
        PlayerSFXPlayer.clip = playerFootstepstSFX;
        PlayerSFXPlayer.Play();
        
        Debug.Log("PlayerRapidFireSFX Played");
    }*/

    public void IgniteFlashLightSFX()
    {
        PlayerSFXPlayer.PlayOneShot(igniteFlashLightSFX);
        Debug.Log("FlashlightSFX Played");
    }

}
