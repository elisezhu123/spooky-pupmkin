using UnityEngine;

public class Die : MonoBehaviour
{
    Score main;
    Transform tr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tr= GetComponent<Transform>();
        main = GameObject.Find("FallingObjects").GetComponent<Score>(); // Get the reference to the main script
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Example functionality: Move the object downwards
        tr.position -= new Vector3(0, 2f, 0); // Move the object downwards by 0.1 units per frame
        if (tr.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(collison.gameObject);
            main.GameOver = true;
        }
    }

}
