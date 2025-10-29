using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed = 10.0f;
    private float horizontalInput, verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moves the Player forwerd and backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Moves the player from left to right
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
