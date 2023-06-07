using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float maxCameraSize; // Maximum camera size
    public Transform player1; // Reference to the first player's transform
    public Transform player2; // Reference to the second player's transform
    public float minCameraSize; // Minimum camera size
    public float zoomFactor; // Additional zoom factor to add padding around players
    public float cameraHeightOffset; // Additional height offset for the camera
    private Camera mainCamera; // Reference to the Camera component

    private void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Update()
    {
        // Calculate the bounds that encapsulate both player positions
        Bounds bounds = new Bounds(player1.position, Vector3.zero);
        bounds.Encapsulate(player2.position);

        // Calculate the desired camera position based on the bounds
        Vector3 desiredPosition = bounds.center - Vector3.forward * 10f;
        desiredPosition.y += cameraHeightOffset; // Apply the height offset

        // Calculate the desired camera size based on the bounds and zoom factor
        float desiredSize = Mathf.Max(bounds.size.x, bounds.size.y) * 0.5f * zoomFactor;

        // Set the camera's position and size
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 10f);
        mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, Mathf.Clamp(Mathf.Max(desiredSize, minCameraSize), minCameraSize, maxCameraSize), Time.deltaTime * 10f);
    }
}
