using UnityEngine;

public class Coin : MonoBehaviour, Iscollectable
{
    [SerializeField] private int price =5;

    void PrintCurrentMoney(int currentMoney){
        Debug.Log($"Current money is {currentMoney}");
    }

    void OnEnable()
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
