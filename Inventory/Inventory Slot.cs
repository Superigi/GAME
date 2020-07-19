using System.Runtime.InteropServices.ComTypes;
public class InvantorySlot
{
    public Image icon;
    public Button removeButton;
    Item item;

    public void AddItem()
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.Intaractable = true;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.Intertable = false;
    }

    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);
    }

    public void UseItem()
    {
        if(item != null)
        {
            item.Use();
        }
    }
}