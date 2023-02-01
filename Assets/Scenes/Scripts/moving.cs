using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    [SerializeField] float movSpeed;
    [SerializeField] float rotSpeed;
    [SerializeField] GameObject cam;
    [SerializeField] GameObject car;

    private Rigidbody rb;
    private float rot, mov;


    void Update()
    {
        rot = Input.GetAxis("Horizontal") * rotSpeed;
        mov = Input.GetAxis("Vertical") * movSpeed;

        transform.Translate(0, mov, 0);
        transform.Rotate(0, 0, -rot);
    }

    private void LateUpdate()
    {
        cam.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -5);
    }


}
