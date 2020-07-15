using System.Diagnostics;
[CreateAssetMenu (fileName = "Net Item", menuName = "Inventory/Item")]
public class Item : ScriptableItem
{
    new public string name = "new item";
    public sprite icon = null;
    public bool IsDeafultItem = false;

    // Using Item
    public virtual void Use()
    {
        Debug.Log("Using " + name);
    }
}