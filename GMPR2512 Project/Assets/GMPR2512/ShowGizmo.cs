using UnityEngine;

namespace GMPR2512
{
public class ShowGizmo : MonoBehaviour
    {
        [SerializeField] private Color _gizmoColor = Color.red;
        [SerializeField] private float _radius = 0.5f;
        void OnDrawGizmos()
        {   
            Gizmos.color = _gizmoColor;
            // "Transform" represents the transform of the game object to which this script is attached
            // We could have also used GetCmponent<Transform>().position
            Gizmos.DrawSphere(transform.position, _radius);
        }
    }
}