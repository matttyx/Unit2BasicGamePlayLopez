using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      


    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player got hit, Game Over!");
        } else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            score += 1;
            Debug.Log("Score:" + score);
        }
    }
}
