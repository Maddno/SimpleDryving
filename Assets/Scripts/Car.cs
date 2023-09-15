using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] private float carSpeed = 10f;
    [SerializeField] private float speedGainPerSecond = 0.1f;
    [SerializeField] private float turnSpeed = 10f;

    private int sterrValue;

    void Start()
    {
        
    }

    void Update()
    {
        carSpeed += speedGainPerSecond * Time.deltaTime;

        transform.Rotate(0f, sterrValue * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }

    // private void OnTriggerEnter(Collider other) 
    // {
    //     if(other.CompareTag("Obstacle"))
    //     {
    //         SceneManager.LoadScene(0);
    //     }
    // }

    public void Steer(int value)
    {
        sterrValue = value;
    }
}
