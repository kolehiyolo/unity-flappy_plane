using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float planeSpeed;
    public float pitchSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.left * Time.deltaTime * pitchSpeed * verticalInput);

        transform.Translate(Vector3.forward * Time.deltaTime * planeSpeed);
    }
}
