using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public Vector3 Speed;
    private Rigidbody rigidbody;
    //public Vector2 speedy;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(Speed * Time.deltaTime, ForceMode.VelocityChange);
        }
	
	}
}
