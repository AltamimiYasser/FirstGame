using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{
    [SerializeField] PlayerMovments movements;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movements.enabled = false;
        }
    }
}
