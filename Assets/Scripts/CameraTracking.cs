using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Niantic.ARDK.AR;
using Niantic.ARDK.AR.ARSessionEventArgs;
using Niantic.ARDK.Rendering;
using Niantic.ARDK.Utilities;
using Niantic.ARDK.Utilities.Editor;
using Niantic.ARDK.Utilities.Logging;
using Niantic.ARDK.VirtualStudio.AR.Mock;

public class CameraTracking : MonoBehaviour
{
    public Text text;
    public Camera camera;
    public Material material;
    private bool visible = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToCamera = Vector3.Distance(transform.position, camera.transform.position);
        text.text = distanceToCamera.ToString();
        if(distanceToCamera < 1.0 && visible)
        {
            //Destroy(gameObject);
        }
    }
}
