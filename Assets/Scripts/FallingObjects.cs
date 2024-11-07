using UnityEngine;

public class FallingObjects : MonoBehaviour
{

    Music music;

    private void Awake()
    { 
        music = GameObject.FindWithTag("Music").GetComponent<Music>(); //finds the music object and gets the music script
    }

    Score main;
    Transform tr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start() //`Start` is called once before the first execution of `Update` after the MonoBehaviour is created
    {
        tr= GetComponent<Transform>();
        main = GameObject.Find("FallingObjects").GetComponent<Score>(); // Get the reference to the main script
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        // Example functionality: Move the object downwards
        tr.position -= new Vector3(0, 4f, 0); // Move the object downwards by 0.1 units per frame
        if (tr.position.y < -2f) // Check if the object is below -7 units in the y-axis
        {
            Destroy(gameObject); // Destroy the object    if it goes below -7 units in the y-axis
        }
    }
    
    void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("Player")) // Check if the object collided with the player
        {
            Destroy(gameObject); // Destroy the object if it collides with the player
            music.PlaySound(music.CandyCapture); // Play the "CandyCapture" sound effect from the audio manager
            main.AddScore(); // Call the AddScore function from the main script to increase the player's score
        }
    }

}
