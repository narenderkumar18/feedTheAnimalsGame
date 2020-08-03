using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public float horizontalInput;
    public float speed = 25.0f;
    public float xRange = 18.0f;
    private float shootTime = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootSandwhich", 2, shootTime);
    }

    // Update is called once per frame
    void Update()
    {
        // for adjusting range for of moment of player
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // for player movement left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }
    void shootSandwhich ()
    {
        Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
    }
}
