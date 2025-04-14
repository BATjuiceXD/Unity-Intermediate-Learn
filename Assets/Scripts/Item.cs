using UnityEngine;

public class Item : MonoBehaviour, Iscollectable
{
    public void Collect()
    {
        Debug.Log("Item collect");
        Destroy(gameObject);
    }
}
