using UnityEngine;

namespace GMPR2512.Lesson06
{
    public class Plunger : MonoBehaviour
    {
        [SerializeField] private Transform _lowestPoint, _stopPoint;
        [SerializeField] private float _velocity = -2, _force = 10;
        private Rigidbody2D _rb;

        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            bool spacePressed = Input.GetKey(KeyCode.Space);
            bool spaceReleased = Input.GetKeyUp(KeyCode.Space);
            // if the spacebar is pressed and the plunger is still above the lowest point
            if(spacePressed && transform.position.y >= _lowestPoint.position.y)
            {
                MovePlungerDown();
            }
            if(spaceReleased)
            {
                ReleasePlunger();
            }
        }
        private void MovePlungerDown()
        {
            transform.Translate(0, _velocity * Time.deltaTime, 0, Space.Self);   
        }
        private void ReleasePlunger()
        {   
            // changes the body type to dynamic, which interacts with the physics engine
            _rb.bodyType = RigidbodyType2D.Dynamic;
            float distance = _stopPoint.position.y - transform.position.y;
            Vector2 impulse = new Vector2(0,_force*distance);
            _rb.AddForce(impulse, ForceMode2D.Impulse);
        }
    }
}
