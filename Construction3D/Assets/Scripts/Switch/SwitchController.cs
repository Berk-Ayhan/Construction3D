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
        private void OnEnable()
        {
            diggerController.onDiggerMove += HandleOnDiggerMove;
        }
        private void HandleOnDiggerMove(SwitchDirection direction)
        {
            switch (direction)
            {
                case SwitchDirection.LEFT:
                    animator.SetBool("isMoving", true);
                    animator.SetBool("isLeft", true);
                    break;
                case SwitchDirection.RIGHT:
                    animator.SetBool("isMoving", true);
                    animator.SetBool("isLeft", false);
                    break;
                case SwitchDirection.IDLE:
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
