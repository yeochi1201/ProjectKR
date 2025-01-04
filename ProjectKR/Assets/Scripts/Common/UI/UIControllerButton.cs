using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIControllerButton : UIBase
{
    GameObject _player;
    MoveDir dir = MoveDir.NONE;
    bool _isMove = false;
    float _speed = 5;
    enum Buttons
    {
        LEFT,
        RIGHT,
        UP,
        DOWN,
    }
    enum Images
    {

    }

    #region Event Function
    private void MoveLeft(PointerEventData data)
    {
        Debug.Log("Move Left");
        dir = MoveDir.LEFT;
        _isMove = true;
    }
    private void MoveRight(PointerEventData data)
    {
        Debug.Log("Move Right");
        dir = MoveDir.RIGHT;
        _isMove = true;
    }
    private void MoveUp(PointerEventData data)
    {
        Debug.Log("Move Up");
        dir = MoveDir.UP;
        _isMove = true;
    }
    private void MoveDown(PointerEventData data)
    {
        Debug.Log("Move Down");
        dir = MoveDir.DOWN;
        _isMove = true;
    }
    private void MoveCancle(PointerEventData data)
    {
        _isMove = false;
    }
    #endregion
    #region BindEvent
    private void BindLeftButton()
    {
        GameObject button = Get<Button>((int)Buttons.LEFT).gameObject;
        AddEvent(button, MoveLeft, UIEvent.DOWN);
        AddEvent(button, MoveCancle, UIEvent.UP);
    }
    private void BindRightButton()
    {
        GameObject button = Get<Button>((int)Buttons.RIGHT).gameObject;
        AddEvent(button, MoveRight, UIEvent.DOWN);
        AddEvent(button, MoveCancle, UIEvent.UP);
    }
    private void BindUpButton()
    {
        GameObject button = Get<Button>((int)Buttons.UP).gameObject;
        AddEvent(button, MoveUp, UIEvent.DOWN);
        AddEvent(button, MoveCancle, UIEvent.UP);
    }
    private void BindDownButton()
    {
        GameObject button = Get<Button>((int)Buttons.DOWN).gameObject;
        AddEvent(button, MoveDown, UIEvent.DOWN);
        AddEvent(button, MoveCancle, UIEvent.UP);
    }
    private void BindEvent()
    {
        BindLeftButton();
        BindRightButton();
        BindUpButton();
        BindDownButton();
    }
    #endregion
    private void Move()
    {
        switch (dir)
        {
            case MoveDir.UP:
                _player.transform.position += _speed * Time.deltaTime * Vector3.up;
                break;
            case MoveDir.DOWN:
                _player.transform.position += _speed * Time.deltaTime * Vector3.down;
                break;
            case MoveDir.LEFT:
                _player.transform.position += _speed * Time.deltaTime * Vector3.left;
                break;
            case MoveDir.RIGHT:
                _player.transform.position += _speed * Time.deltaTime * Vector3.right;
                break;
            default:
                break;
        }

    }
    private void Start()
    {
        _player = PlayerState.Player;
        Debug.Log(PlayerState.PlayerSpec.Speed);
        Bind<Button>(typeof(Buttons));
        BindEvent();
    }
    private void Update()
    {
        if (_isMove)
        {
            Move();
        }
    }
}
