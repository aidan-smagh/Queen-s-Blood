using UnityEngine;

public class FitBoardToCamera : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr == null)
        {
            Debug.LogError("No sprite renderer found");
            return;
        }
        Camera cam = Camera.main;
        if (cam == null)
        {
            Debug.LogError("No camera found");
            return;
        }
        Vector2 spriteSize = sr.sprite.bounds.size;
        float cameraHeight = cam.orthographicSize * 2f;
        float cameraWidth = cameraHeight * cam.aspect;
        transform.localScale = new Vector3(cameraWidth / spriteSize.x, cameraHeight / spriteSize.y, 1);
    }
}
