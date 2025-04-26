using UnityEngine;

[System.Serializable]
public class CameraHandler {
    [SerializeField] private Transform thisTransform;
    [SerializeField] private Transform target;

    public void LateUpdate() {
        thisTransform.position = new Vector3(target.position.x, thisTransform.position.y, thisTransform.position.z);
    }
}
