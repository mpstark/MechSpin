using UnityEngine;
using UnityEngine.EventSystems;

namespace MechSpin
{
    public class SpinComponent : MonoBehaviour
    {
        public float BleedPerSec = 8f;
        public float HorizontalSpeed = -5f;
        private float _curSpeed;

        public void Update()
        {
            if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                _curSpeed = HorizontalSpeed * Input.GetAxis("Mouse X");
            }
            else
            {
                var absoluteSpeed = Mathf.Abs(_curSpeed);
                var bleed = BleedPerSec * Time.deltaTime;

                if (absoluteSpeed <= bleed)
                {
                    _curSpeed = 0f;
                    return;
                }

                absoluteSpeed -= bleed;

                if (_curSpeed < 0)
                    absoluteSpeed *= -1;

                _curSpeed = absoluteSpeed;
            }

            transform.Rotate(0, _curSpeed, 0);
        }
    }
}
