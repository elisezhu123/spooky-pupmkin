using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource MusicPlayer;// Music to play
    [SerializeField] AudioSource SoundEffects;// Music to play
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public AudioClip Menu;
    public AudioClip PlayingGame;
    public AudioClip GameOver;
    public AudioClip CandyCapture;

    private void Start(){
        MusicPlayer.clip = PlayingGame;
        MusicPlayer.Play();
    }

    public void PlaySound(AudioClip clip){
        SoundEffects.PlayOneShot(clip);
    }


}
