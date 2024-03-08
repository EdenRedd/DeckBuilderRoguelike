using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public GameEvent onMouseDown;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit != null && hit.collider != null)
            {
                onMouseDown.RaiseSignal(this, hit.collider.gameObject);
            }

        }
    }
}
