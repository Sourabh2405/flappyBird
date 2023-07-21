using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody2D rb;
    public float force = 1;
    // Start is called before the first frame update
    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) )
        {
            rb.velocity = Vector2.up * force;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "obstacles" || collision.gameObject.tag=="grass")
        {
            Debug.Log("GameOver");
            GameManager.instance.isGameOver = true;
            GameManager.instance.GameOverPanel.SetActive(true);    
        }
    }
}
