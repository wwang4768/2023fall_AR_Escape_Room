using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchScript : MonoBehaviour
{
    public Text phaseDisplayText;
    public GameObject Button;
    public Camera arcam;
    private Touch touch;
    private float timeTouchEnded;
    private float displayTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
			// Get the coordinates of the center of the Button cylinder
            Vector3 button_pos = arcam.WorldToScreenPoint(Button.transform.position);
			// Display the touch position on the label
			phaseDisplayText.text = "Touch Recongizned " + button_pos;
			
			
			
			// Here is where we'd do more stuff
			// Get touch objects
            Touch touch = Input.GetTouch(0);
			// vector2 world_pos=arcam.main.ScreenToWorldPoint(touch.position); //TODO: Check if that's the right conversion/datatype
			
			
			//// This was me trying to create a object, not working right now. Please ignore
            // Create a new cube primitive to set the color on
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            // Get the Renderer component from the new cube
            var cubeRenderer = cube.GetComponent<Renderer>();

            // Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.red);
            //
            

        }

    }
}
