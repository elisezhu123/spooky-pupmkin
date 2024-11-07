using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    public Animator animator;
    Score main;
    Transform tr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //`Start` is called once before the first execution of `Update` after the MonoBehaviour is created
    {
        animator = GetComponent<Animator>();
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
            main.AddScore(); // Call the AddScore function from the main script to increase the player's score
        }
    }

}
