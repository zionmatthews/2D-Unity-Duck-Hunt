using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * A class that places the GameObject crosshair
 * along with the camera's rl world axis and 
 * follows the mouse position
 */
public class CrossHair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the cursors position to the camera's world position
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);

        Cursor.visible = false;
    }
}
