using UnityEngine;

namespace GMPR2512.Lesson04Scripting01
{
    public class DeathZone : MonoBehaviour
    {

        [SerializeField] private int _year = 1000;
        private float _seconds = 0;
        // Awake is called once before Start()
        void Awake()
        {
            _year += 1026;
            Debug.Log($"I'm awake! It's the year {_year}");
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log($"Let's get started! It's finally the year {_year}");
            _year ++;
        }

        // Update is called once per frame
        void Update()
        {

            _seconds += Time.deltaTime;

            // Debug.Log($"This scene has been running for {_seconds:f2}s");
        }
        // If two game objects touch
        // and both have colliders (one must be a trigger)
        // and at least one has a Rigidbody2D, this method is called
        void OnTriggerEnter2D(Collider2D collider)
        {
            Debug.Log("Boom");
            // collider represents the collider of the game object that bumped into us
            Destroy(collider.gameObject);
            // Destroy(collider.gameObject.GetComponent<Rigidbody2D>());
            // Destroy(collider);
        }
    }
}
