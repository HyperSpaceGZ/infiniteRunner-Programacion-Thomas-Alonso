using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovementWASD : MonoBehaviour
{
    public int jumpforce = 5;
    public bool isjumping = false;
    public ScoreScript ScoreScript;
    public float TimeNumber = 1;

    public Animator Animator;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSeconds());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isjumping == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpforce, 0);
            isjumping = true;
            Animator.Play("JumpAnim");
            StopCoroutine("WaitSeconds");
        }

        if (Input.GetKeyDown("r"))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Menu"); ;
            StopCoroutine("WaitSeconds");

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            Application.Quit();
            StopCoroutine("WaitSeconds");
        }

        Time.timeScale = TimeNumber;
    }

    private IEnumerator WaitSeconds()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(2);
            TimeNumber += 0.01f;
        }


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Floor")
        {
            isjumping = false;
            Animator.SetBool("IsJumping", false);
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("Death"); ;
        }

    }

}