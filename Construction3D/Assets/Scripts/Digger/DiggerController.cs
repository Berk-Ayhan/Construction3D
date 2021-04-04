using UnityEngine;

public class DiggerController : MonoBehaviour
{
    private Rigidbody _rb;
    private Mover _mover;
    private Vector3 _directionX;
    private float _mouseXPos;
    private bool _isClicked, _isDigging, _isCanceled;
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _mover = GetComponent<Mover>();
    }
    void Update()
    {
        _mouseXPos = Input.GetAxis("Mouse X");
        _directionX = new Vector3(_mouseXPos, 0, 0);
        CheckMouseClick();
    }
    void FixedUpdate()//Movement control
    {
        if (_isDigging) 
        {
            _mover.MoveDown();
        }
        else if (_isCanceled)
        {
            _mover.MoveUp();
        }
        else
        {
            if (_isClicked)
            {
                if (_mouseXPos != 0)
                {
                    _mover.MoveHorizontal(_rb, _directionX);
                }
                else
                {
                    _mover.StopHorizontal(_rb);
                }
            }
            else
            {
                _mover.StopHorizontal(_rb);
            }
        }
    }
    private void CheckMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            _isClicked = true;
        }
        else
        {
            _isClicked = false;
            if (Input.GetMouseButtonUp(0))
            {
                _isDigging = true;
            }
        }
    }
}
