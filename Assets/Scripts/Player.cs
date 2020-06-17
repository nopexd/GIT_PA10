using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    //public float speed = 2;
    public float force = 100;
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
      // Rigidbody= GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector2.up * force);
            thisAnimation.Play();
        }

      
    }
    void OnTriggerEnter(Collider other)
    {
        


        if (other.tag == "obstacle")
        {
            SceneManager.LoadScene("restart");

        }

    }
}
