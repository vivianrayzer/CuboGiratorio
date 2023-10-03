using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float xTilt;
    public void Start()
    {
        if (target != null) return;

        target = gameObject.transform;
        Debug.Log("Target não específicado");
    }

    // Update is called once per frame
    private void Update()
    {
        transform.RotateAround(target.position, new Vector3(xTilt, 1, 0), speed * Time.deltaTime);
    }
}
