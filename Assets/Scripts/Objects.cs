using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Objects : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    [SerializeField] float secondSpawn = 1f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    

    void Start()
    {
        StartCoroutine(ObjectSprawn());
    }

    IEnumerator ObjectSprawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position  = new Vector3(wanted, transform.position.y, 0);
            GameObject gameObject =Instantiate(objects[Random.Range(0, objects.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
