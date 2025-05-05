using Sirenix.OdinInspector;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region HashTable
    private MyHashTable<int, string> myHashTable = new MyHashTable<int, string>(10);
    #endregion

    #region Methods
    void Start()
    {
        myHashTable.Add(1, "One");
        myHashTable.Add(2, "Two");
        myHashTable.Add(3, "Three");
        myHashTable.Add(4, "Four");
        myHashTable.Add(5, "Five");
        myHashTable.Add(6, "Six");
        myHashTable.Add(7, "Seven");
        myHashTable.Add(8, "Eight");
        myHashTable.Add(9, "Nine");
        myHashTable.Add(20, "Twenty");
    }

    [Button ("Leer Key")]
    public void SearchValue(int key)
    {
        string value = myHashTable.Get(key);
        if (value != null)
        {
            Debug.Log(value);
        }
    }
    #endregion
}
