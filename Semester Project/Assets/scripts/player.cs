using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    public int coinCount;
    public Transform finish;
    public TMP_Text score_text;

    void Start()
    {
        score_text.text = "Coins:"+coinCount;
    }

    void Update()
    {
        if (gameObject.name == "Player1")
        {
            if(Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);
            }
        }
        if (gameObject.name == "Player2")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);
            }
        }
    }
    public void ring()
    {
        GetComponent<AudioSource>().Play();
        score_text.text = "Coins:" + coinCount;
    }
}
