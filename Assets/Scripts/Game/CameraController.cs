using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float FOLLOWSPEED = 2f;
    [SerializeField]
    private Transform player_target;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    private void LateUpdate()
    {
        if (transform.position != player_target.position)
        {
            Vector3 newPos = new Vector3(player_target.position.x, player_target.position.y, transform.position.z);

            newPos.x = Mathf.Clamp(newPos.x, minPosition.x, maxPosition.x);
            newPos.y = Mathf.Clamp(newPos.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, newPos, FOLLOWSPEED * Time.deltaTime);
        }
    }
}
