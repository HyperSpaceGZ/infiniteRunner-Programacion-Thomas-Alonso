using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovementWASD : MonoBehaviour
{
    public int jumpforce = 5;
    public bool isjumping = false;
    public Text Restart;
    public Text Instructions;
    public ScoreScript ScoreScript;

    // Start is called before the first frame update
    void Start()
    {
        Restart.enabled = false;
        Instructions.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isjumping == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpforce, 0);
            isjumping = true;
        }

        if (Input.GetKeyDown("r"))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            Application.Quit();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Floor")
        {
            isjumping = false;
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            Restart.enabled = true;
            Instructions.enabled = false;
        }

    }

}