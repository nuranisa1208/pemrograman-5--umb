using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision.Collision)
    {
        if (Collision.Collision. CompareTag("virus"))
        {
            score +=100;
            Destroy(Collision.collider.GameObject);
        }
    }
}
