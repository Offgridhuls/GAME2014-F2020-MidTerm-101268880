using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [Header("BackgroundController, " +
            "Julian Sangiorgio," +
            "101268880," +
            "2021-10-18," +
            "Horizontal Background Movement")]
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary + 5, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3((horizontalSpeed) * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
