using UnityEngine;

public class TestObject : MonoBehaviour
{
    void Start()
    {
        Debug.Log(PlayerController.Instance._jumpForce);
    }

}
