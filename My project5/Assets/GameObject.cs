using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    public Transform MaxposE;
    public Transform MinposE;
    public Transform MidposE;

    public GameObject Ename;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Instantiate (Ename,MidposE);

    }
}
