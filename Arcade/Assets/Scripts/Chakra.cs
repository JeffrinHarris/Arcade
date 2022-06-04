using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Chakra : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    public float timeRemaining = 1f;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // rb.velocity = new Vector2 (velocity, 0);
        transform.position += transform.right * Time.deltaTime * speed;
        if (timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
        }
        else {
            Destroy(gameObject);
        }
    }
}
