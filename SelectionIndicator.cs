using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionIndicator : MonoBehaviour
{
    private MouseManager mm;

    // Start is called before the first frame update
    private void Start()
    {
        mm = GameObject.FindObjectOfType<MouseManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (mm.selectedObject != null)
        {
            this.transform.position = mm.selectedObject.transform.position;
        }
    }
}