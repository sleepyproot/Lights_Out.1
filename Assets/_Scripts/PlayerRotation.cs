using UnityEngine;
using UnityEngine.InputSystem;

namespace TopDown.Movement
{
    public class PlayerRotation : Rotator
    {
        private Vector2 screenMousePosition;

        private void Update()
        {
            Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition);

            LookAt(worldMousePosition);

        }
        private void OnLook(InputValue value)
        {
            screenMousePosition = value.Get<Vector2>();
        }
    }
}

