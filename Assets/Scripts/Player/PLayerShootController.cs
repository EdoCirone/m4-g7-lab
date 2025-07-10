using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerShootController : MonoBehaviour
{

    [SerializeField] float _maxDistance = 10;
    [SerializeField] private LayerMask _hitMask = ~0; // "Tutti i layer" di default
    Ray ray;
    Vector3 _rayOrigin;
    Vector3 _rayDir;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click rilevato");

            _rayDir = transform.forward;
            _rayOrigin = transform.position;

            ray = new Ray(_rayOrigin, _rayDir);

            if (Physics.Raycast(ray, out RaycastHit hit, _maxDistance, _hitMask))
            {
                Debug.Log("Colpito: " + hit.collider.name);
                Debug.DrawRay(ray.origin, ray.direction * _maxDistance, Color.red, 1f);

                IHittable hittable = hit.collider.GetComponent<IHittable>();
                hittable?.Hit();
            }
        }
    }

    void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawRay(_rayOrigin, _rayDir * _maxDistance);
    }

}
