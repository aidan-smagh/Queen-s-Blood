using UnityEngine;

public class FitBoardToCamera : MonoBehaviour
{
    void start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr == null)
        {
            Debug.LogError("No sprite renderer found");
            return;
        }
        Camera cam = Camera.main();
        if (cam == null)
        {
            Debug.LogError("No camera found");
            return;
        }
        
    }
}
