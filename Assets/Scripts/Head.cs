using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Head : MonoBehaviour
{
    [System.NonSerialized]
    public Rigidbody myRigidbody;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        print("Hello " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddForce(float force)
    {
        GetComponent<Rigidbody>().AddForce(0, force, 0);
    }
}
