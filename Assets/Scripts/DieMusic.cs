using UnityEngine;

public class DieMusic : MonoBehaviour
{
    [SerializeField] AudioSource FuckMusic;// Music to play
    
   
    public AudioClip GameOver;


    private void Start(){
        FuckMusic.clip = GameOver;
        FuckMusic.Play();
    }


}