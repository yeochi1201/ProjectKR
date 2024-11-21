using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Attribute
    float speed = 5f;
    MoveDir dir = MoveDir.NONE;
    #endregion

    #region Function
    private void GetDirectionInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            dir = MoveDir.UP;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            dir = MoveDir.DOWN;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = MoveDir.LEFT;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            dir = MoveDir.RIGHT;
        }
        else
        {
            dir = MoveDir.NONE;
        }
    }
    private void Move()
    {
        switch (dir)
        {
            case MoveDir.UP:
                transform.position += Vector3.up * Time.deltaTime * speed;
                break;
            case MoveDir.DOWN:
                transform.position += Vector3.down * Time.deltaTime * speed;
                break;
            case MoveDir.LEFT:
                transform.position += Vector3.left * Time.deltaTime * speed;
                break;
            case MoveDir.RIGHT:
                transform.position += Vector3.right * Time.deltaTime * speed;
                break;
            default:
                break;
        }

    }
    #endregion

    #region Unity
    private void Update()
    {
        GetDirectionInput();
        Move();
    }
    #endregion
}
