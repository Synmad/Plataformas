using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] Transform platformtransform;
    [SerializeField] Transform waypointatransform;
    [SerializeField] Transform waypointbtransform;

    int direction = 1;

    [SerializeField] float speed = 1.0f;

    private void Awake()
    {
        
    }

    private void Update()
    {
        Vector2 target = CurrentTarget();
        platformtransform.position = Vector2.Lerp(platformtransform.position, target, speed * Time.deltaTime);

        float distance = (target - (Vector2)platformtransform.position).magnitude;

        if (distance <= 0.1f)
        {
            direction *= -1;
        }
    }

    Vector2 CurrentTarget() 
    {
        if (direction == 1)
        {
            return waypointatransform.position;
        }
        else
        {
            return waypointbtransform.position;
        }
    }
}
