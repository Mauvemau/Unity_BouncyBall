using UnityEngine;

public class BallLogic : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity = new Vector3(3, 2, 0);

    private void Update()
    {
        this.transform.position += velocity * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Overlapped with " + other.name + "!!");
        Vector3 contactPoint = other.ClosestPoint(transform.position);
        Vector3 direction = contactPoint - transform.position;

        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y) && Mathf.Abs(direction.x) > Mathf.Abs(direction.z))
        {
            velocity.x = -velocity.x;
        }
        else
        {
            velocity.y = -velocity.y;
        }
    }

}
