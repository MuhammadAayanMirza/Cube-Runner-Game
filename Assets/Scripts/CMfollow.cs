using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    private Transform playerTransform;

    [Header("Camera Offset")]
    public float zOffset = -10f; 
    public float yOffset = 1f;   

    [Header("Smoothness")]
    public float followSpeed = 10f; // Increased speed slightly to track physics better

    // 👈 1. CHANGED TO FIXEDUPDATE: This locks the camera timeline to the player's physics loop
    void FixedUpdate()
    {
        if (playerTransform == null)
        {
            Transform foundClone = FindSpawnedClone();
            if (foundClone != null)
            {
                playerTransform = foundClone;
            }
        }

        if (playerTransform != null)
        {
            Vector3 targetPosition = playerTransform.position;
            targetPosition.z += zOffset;
            targetPosition.y += yOffset;

            // 👈 2. CHANGED TO FIXEDDELTATIME: Uses the stable physics clock instead of variable frames
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.fixedDeltaTime);
        }
    }

    private Transform FindSpawnedClone()
    {
        GameObject[] rootObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
        foreach (GameObject obj in rootObjects)
        {
            if (obj.name.Contains("(Clone)"))
            {
                return obj.transform;
            }
        }
        return null;
    }
}

