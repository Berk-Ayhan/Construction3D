using UnityEngine;
using Construction3D.Switch;

namespace Construction3D.Digger
{
    public class DiggerController : MonoBehaviour
    {
        public event System.Action<SwitchDirection> onDiggerMove;

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
                    SwitchDirectionSetter(_mouseXPos);
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
                    SwitchDirectionSetter(0);
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
        private void SwitchDirectionSetter(float direction)
        {
            if (direction < 0)
            {
                onDiggerMove?.Invoke(SwitchDirection.LEFT);
            }
            else if(direction > 0)
            {
                onDiggerMove?.Invoke(SwitchDirection.RIGHT);
            }
            else
            {
                onDiggerMove?.Invoke(SwitchDirection.IDLE);
            }
        }
    }
}

