using UnityEngine;

public class Collectible : MonoBehaviour
{
    //Set a trigger when the object collides with something
    private void OnTriggerEnter(Collider other)
    {
        //Destroys the object
        Destroy(gameObject);
    }
}