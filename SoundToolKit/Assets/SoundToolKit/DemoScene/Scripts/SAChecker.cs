using UnityEngine;

public class SAChecker : MonoBehaviour
{
    void Start()
    {
        Component[] components = gameObject.GetComponents<Component>();

        foreach (var component in components)
        {
            if (component == null)
            {
                Debug.LogWarning("[SoundToolKit] Characters package missing in the project. Please import StandardAssets/Characters package in order for the demo scene to work.");
            }
        }
    }
}
