using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int price;

    void PrintCurrentMoney(int currentMoney){
        Debug.Log($"Current money is {currentMoney}");
    }

    void Onable()
    {
        GameManager.Instance.OnMoneyChanged.AddListener(PrintCurrentMoney);
    }
    private void OnDisable()
    {
        GameManager.Instance.OnMoneyChanged.AddListener(PrintCurrentMoney);
    }
    public void Collect()
   {
        GameManager.Instance.Money = price;
        Destroy(gameObject);
   }
}
