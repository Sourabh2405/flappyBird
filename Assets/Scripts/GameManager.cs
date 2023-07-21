using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject obstaclePrefab;
    public float timer = 0f;
    public bool isGameOver = false;
    public GameObject GameOverPanel;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;  
    }

    private void Start()
    {
        isGameOver = false;
        GameOverPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (timer <= 0f)
        {   
            if(isGameOver == false)
            {
                GameObject gm = Instantiate(obstaclePrefab,new Vector3(5f,Random.Range(0f,2f),0f),Quaternion.identity);
                Destroy(gm, 10f);
                timer = 2f;

            }
        }
        else
        {
            timer = timer - Time.deltaTime;
        }
    }
    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
