using UnityEngine;

public class generator : MonoBehaviour
{
    float timer = 1;
    public GameObject[] gm; // gm[0], gm[1], and gm[2] are regular objects; gm[3] has special behavior

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            int chance = Random.Range(1, 101);
            float pos_x = Random.Range(48.0f, 834.0f); // Random position within range

            if (chance <= 10 && gm.Length > 0)  // Spawn gm[0] with 10% chance
            {
                Instantiate(gm[0], new Vector3(pos_x, 600f, 0.1f), Quaternion.identity);
            }
            else if (chance > 10 && chance <= 20 && gm.Length > 1) // 10% chance for gm[1]
            {
                Instantiate(gm[1], new Vector3(pos_x, 700f, 0.1f), Quaternion.identity);
            }
            else if (chance > 20 && chance <= 30 && gm.Length > 2) // 10% chance for gm[2]
            {
                Instantiate(gm[2], new Vector3(pos_x, 600f, 0.1f), Quaternion.identity);
            }
            else if (chance > 30 && gm.Length > 3) // 70% chance for gm[3], handled by another script
            {
                Instantiate(gm[3], new Vector3(pos_x, 800f, 0.1f), Quaternion.identity);
            }

            timer = 0.7f; // Reset the timer
        }
    }
}