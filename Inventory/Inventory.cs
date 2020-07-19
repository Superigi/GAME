using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
public class Inventory
{
    #region Sineleton

    public int space = 20;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public static Inventory instance;
    public List<Item> items = new list<Item>();

    public bool add (Item item);

    void awake()
    {
        if(istance != null)
        {
            Debug.LogWarning("More thanone instance od Inventory found!");
            return;
        }
        instance = this;
    }

    #endregion

    public void  add (Item item)
    {
        if(!item.IsDeafultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("not enought space");
                return false;
            }

            items.add(item);
            if(onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
            
        }
        return true;
    }

    public void Remove (Item item)
    {
        items.Remove(item);

        if(onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}