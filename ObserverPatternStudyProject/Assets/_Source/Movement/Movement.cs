using UnityEngine;

namespace DayCycleSystem
{
    public class Movement : MonoBehaviour
    {
        private Vector3 _rotationEuler = Vector3.zero;

        public void MoveAcrossSky(float angle)
        {
            _rotationEuler.z = angle;

            transform.rotation = Quaternion.Euler(_rotationEuler);
        }
    }
}