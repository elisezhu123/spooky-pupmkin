using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    [SerializeField] AudioSource StartMusic;// Music to play
    
   
    public AudioClip GameOver;


    private void Start(){
        StartMusic.clip = GameOver;
        StartMusic.Play();
    }


}