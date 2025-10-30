using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed = 10.0f;
    //Player input
    private float horizontalInput, verticalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moves the Player forwards and backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Moves the player from left to right
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
