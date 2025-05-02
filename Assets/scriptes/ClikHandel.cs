using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClikHandel : MonoBehaviour
{
    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Convert mouse position to world position
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Check if the mouse position overlaps with the collider
            Collider2D collider = Physics2D.OverlapPoint(worldPoint);

            // If the collider is this object's collider, handle the click
            if (collider != null && collider.gameObject == gameObject)
            {
                OnClick();
            }
        }
    }

    // Define what happens when the object is clicked
    protected virtual void OnClick()
    {
        // To be overridden in derived classes
    }
}
