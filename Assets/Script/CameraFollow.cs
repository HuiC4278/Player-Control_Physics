using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3, -7);
    //Camera follows the player behind
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
