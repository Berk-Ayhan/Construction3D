using UnityEngine;
using Construction3D.Digger;

namespace Construction3D.Switch
{
    public class SwitchController : MonoBehaviour
    {
        private Animator animator;
        private DiggerController diggerController;
        private void Awake()
        {
            animator = GetComponent<Animator>();
            diggerController = FindObjectOfType<DiggerController>();
        }
        private void Start()
        {
            diggerController.onDiggerMove += HandleOnDiggerMove;
        }
        private void HandleOnDiggerMove(Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    animator.SetBool("isMoving", true);
                    animator.SetBool("isLeft", true);
                    break;
                case Direction.RIGHT:
                    animator.SetBool("isMoving", true);
                    animator.SetBool("isLeft", false);
                    break;
                case Direction.IDLE:
                    animator.SetBool("isMoving", false);
                    break;
            }
        }
        private void OnDestroy()
        {
            diggerController.onDiggerMove -= HandleOnDiggerMove;
        }
    }

}
