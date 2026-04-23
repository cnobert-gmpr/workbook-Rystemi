using UnityEngine;
using System.Collections;

namespace GMPR2512.Lesson09Platformer
{
    public class PlatformFalling : MonoBehaviour
    {
        private Renderer _renderer;
        private Rigidbody2D _rb2d;

        void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _rb2d = GetComponent<Rigidbody2D>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            _renderer.material.color = Color.crimson;
            StartCoroutine("WaitThenFall");
        }

        IEnumerator WaitThenFall()
        {
            yield return new WaitForSeconds(2);
            _rb2d.bodyType = RigidbodyType2D.Dynamic;
        }
    }      
}
