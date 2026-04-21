using UnityEngine;

public class MoveCon : MonoBehaviour
{
    public float speed_X = 5.0f;

    void Update()
    {
        transform.Translate(Vector3.right* speed_X*Time.deltaTime);
    }
}
