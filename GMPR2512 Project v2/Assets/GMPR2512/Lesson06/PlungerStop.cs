using UnityEngine;

namespace GMPR2512.Lesson06
{
    public class PlungerStop : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            // normally we would check the tag, but we can also check the name
            if(collision.gameObject.name == "Plunger")
            {
                collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            }
        }
    }
}
