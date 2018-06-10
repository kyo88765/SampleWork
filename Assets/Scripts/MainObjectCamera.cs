using UnityEngine;

public class MainObjectCamera : MonoBehaviour
{
    [SerializeField]
    Transform mainObjectTransform;

    void LateUpdate()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        var pos = mainObjectTransform.position + (transform.forward * -10f);
        transform.position = Vector3.Slerp(transform.position, pos, Time.deltaTime * 100f);
    }

    public void AddRotation(float x, float y)
    {
        // 縦回転
        var rot = Quaternion.AngleAxis(x, transform.right) * transform.rotation;
        var euler = rot.eulerAngles;
        euler.x = euler.x > 180f ? euler.x - 360f : euler.x;
        euler.x = Mathf.Clamp(euler.x, -45f, 45f);
        euler.z = 0;
        rot = Quaternion.Euler(euler);
        // 横回転
        transform.rotation = Quaternion.AngleAxis(y, Vector3.up) * rot;
    }
}
