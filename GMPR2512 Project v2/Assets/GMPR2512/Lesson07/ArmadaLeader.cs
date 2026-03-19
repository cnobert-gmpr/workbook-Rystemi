using UnityEngine;

namespace GMPR2512.Lesson07
{
    public class ArmadaLeader : MonoBehaviour
    {
        private float _speed = 1;
        private Vector2 _direction = new Vector2(1,0);

        internal Vector2 Direction
        {
            get => _direction;
            set => _direction = value;
        }

        void Update()
        {
            transform.Translate(_direction.normalized * _speed * Time.deltaTime);
        }
    }
}
