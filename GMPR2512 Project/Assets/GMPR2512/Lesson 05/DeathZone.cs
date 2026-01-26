using UnityEngine;

namespace GMPR2512.Lesson05DeathzoneAndRespawn
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private Transform _spawnpoint;
        void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.gameObject.CompareTag("Ball"))
            {
                // Wait 2s, respawn the ball at pre-determined spawnpoint
                StartCoroutine(RespawnBall(collider2D.gameObject));
                // Destroy(collider2D.gameObject);
            }
        }
        private IEnumerator RespawnBall(GameObject ball)
        {
            yield return new WaitForSeconds(2);
            Debug.Log("It's been 2s since the ball has left the gameplay!");
        }
    }
}
