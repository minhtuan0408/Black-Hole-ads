using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Joystick joystick;

    void Update()
    {
        Vector2 joyInput = joystick.GetInput();
        Vector3 move = new Vector3(joyInput.x, 0f, joyInput.y);

        if (move.magnitude > 1f)
            move.Normalize();

        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
    }
}
