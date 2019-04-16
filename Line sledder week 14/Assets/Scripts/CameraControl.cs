using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform sledTransform;
    public Vector3 Offset;

    // Start is called before the first frame update
    void Start()
    {
        Offset = transform.position - sledTransform.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sledTransform.position + Offset;
    }
}
