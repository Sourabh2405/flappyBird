using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public float speed = 10f;
    void Update()
    {
        if (GameManager.instance.isGameOver == false)
        {
            transform.Translate(Vector2.left*Time.deltaTime*speed);

        }
        
    }
}
