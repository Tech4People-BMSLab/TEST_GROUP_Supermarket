using UnityEngine;

namespace _BMSLabSource.Scripts.Runtime.Utilities
{
    public class SlowFollow : UtilityBase
    {
        [SerializeField, Tooltip("The speed of following. Lower values make it smoother.")]
        private float _followSpeed = 1.5f;

        private void LateUpdate()
        {
            if (_active == true && _target != null)
            {
                // Calculate the desired position by interpolating between the current position and the target's position
                Vector3 desiredPosition = new(_target.transform.position.x, transform.position.y, _target.transform.position.z);

                // Use SmoothDamp to smoothly move to the desired position
                transform.position = Vector3.Lerp(transform.position, desiredPosition, _followSpeed * Time.deltaTime);
            }
        }
    }
}