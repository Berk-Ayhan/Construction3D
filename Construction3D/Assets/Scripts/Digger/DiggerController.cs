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
        CheckDiggerYPosition();
    }
    void FixedUpdate()//Movement control
    {
        if (_isDigging) 
        {
            _mover.MoveDown(_rb);
        }
        else if (_isCanceled)
        {
            _mover.MoveUp(_rb);
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
        } // Horizontal position setter
    }
    private void CheckMouseClick()
    {
        if (Input.GetMouseButtonDown(0) && _isDigging)
        {
            _isDigging = false;
            _isCanceled = true;
        } //Digging canceler 
        else if (Input.GetMouseButton(0))
        {
            _isClicked = true;
        }
        else
        {
            _isClicked = false;
            if (Input.GetMouseButtonUp(0) && !_isCanceled)
            {
                print("Digging Started");
                _isDigging = true;
            }// Digging starter
        }
    }
    private void CheckDiggerYPosition()
    {
        if (_rb.position.y >= 4)
        {
            _isCanceled = false;
        }
    }
}
