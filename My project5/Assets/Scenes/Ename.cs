using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ename : MonoBehaviour
{
    Rigidbody rb;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        rb.velocity = new Vector3(0f,0f,Speed);


    }
    private void OnCollisionEnter(Collision collision)
    {

        SceneManager.LoadScene(0);
    }

}
