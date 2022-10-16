using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class MouseMoveControler : MonoBehaviour
    {
        [SerializeField]
        private Camera mainCamera;

        private Vector3 _mousePosition;

        private Vector3 offset = new Vector3(0, 5, 0);

        public void Update()
        {
            var ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray, out RaycastHit raycastHit))
                {
                    transform.position = raycastHit.point + offset;

                    Debug.Log(raycastHit.point);
                }
            }
          

        }

        //2d

  /*      if (Input.GetMouseButtonDown(0))
            {
                _mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
                _mousePosition.z = 0f;

                gameObject.transform.position = _mousePosition;

                Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
            }*/
}
}
