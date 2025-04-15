using UnityEngine;
using UnityEngine.Windows;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class GetComponents : MonoBehaviour
{
    public Color color; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyUp(KeyCode.Return))
            GetComponent<MeshRenderer>().material.color = color;
        if (UnityEngine.Input.GetKeyUp(KeyCode.Space))
        {
            GetComponentInChildren<MeshRenderer>().transform.Translate(1, 0, 0);
            GetComponent<Rigidbody>().AddForce(0, 500, 0);
            GetComponentInChildren<Head>().AddForce(500);
            //GetComponentInChildren<MeshRenderer>().enabled = false;
            Camera.main.fieldOfView *= 2;
            Camera.main.transform.Translate(0, 0, 5);


        }

    }
}
