using UnityEngine;

namespace Scripts.Helpers
{
    static class MoveHelper
    {
        public static KeyCode[] PlayersDirectionKeys = new KeyCode[] { KeyCode.RightArrow, KeyCode.LeftArrow, KeyCode.UpArrow, KeyCode.DownArrow };
        public static KeyCode[] CameraDirectionKeys = new KeyCode[] { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.Keypad2, KeyCode.Keypad8 };

        public static bool ShouldChangePosition(KeyCode[] directionKeys, out KeyCode holdedKeyCode)
        {
            foreach (var keyCode in directionKeys)
            {
                if (IsKeyHoldsDown(keyCode))
                {
                    holdedKeyCode = keyCode;
                    return true;
                }
            }

            holdedKeyCode = KeyCode.None;
            return false;
        }

        public static Vector3 GetDirection(KeyCode keyCode)
        {
            switch (keyCode)
            {
                case KeyCode.RightArrow:
                case KeyCode.D:
                    return Vector3.right;
                case KeyCode.LeftArrow:
                case KeyCode.A:
                    return Vector3.left;
                case KeyCode.UpArrow:
                case KeyCode.W:
                    return Vector3.forward;
                case KeyCode.DownArrow:
                case KeyCode.S:
                    return Vector3.back;
                case KeyCode.Keypad2:
                    return Vector3.down;
                case KeyCode.Keypad8:
                    return Vector3.up;
                default:
                    return Vector3.zero;
            }
        }

        public static Quaternion GetQuaternion(KeyCode keyCode)
        {
            switch (keyCode)
            {
                case KeyCode.Keypad2:
                    return new Quaternion(-1,0,0,0);
                case KeyCode.Keypad8:
                    return new Quaternion(1, 0, 0, 0);

                default:
                    return new Quaternion(0, 0, 0, 0);
            }
        }

        private static bool IsKeyHoldsDown(KeyCode keyCode) => Input.GetKey(keyCode);

        public static Vector3 RandomPosition(int xRange = 10, int yRange = 10, int zRange = 10)
        {
            return new Vector3(Random.Range(-xRange, xRange), yRange, zRange);
        }

        public static Vector3 RandomDirection(Vector3[] directions)
        {

            var numberOfDirections = directions.Length;
            if (numberOfDirections > 0)
            {
                var directionalFactor = Random.Range(0.1f, 1f);
                //var direction =
                    return directions[Random.Range(0, numberOfDirections - 1)];

               // return new Vector3(direction.x * directionalFactor, direction.y * directionalFactor, direction.z * directionalFactor);
            }

            return Vector3.zero;
        }


    }
}
