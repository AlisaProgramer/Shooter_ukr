using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    public int money = 0;
    public static MoneySystem Instance;
    public TMP_Text moneyCountText;
    // Start is called before the first frame update
    public void Start()
    {
        Instance = this;
        moneyCountText.text = money.ToString() + " $";
    }
    public void GetMoney(int enemycost)
    {
        money += enemycost;
        moneyCountText.text = money.ToString()+" $";
    }

}
