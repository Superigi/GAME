using System.Diagnostics;
public class InventoryIU
{
    public transform ItemsPattern;
    public GameObject InventoryUI;
    Inventory inventory;
    InventorySlots[] slots;
    void start()
    {
        inventory = Inventory.instance;
        invantory.OnItemChangenCallback += UpdateIU;

        slots = ItemsPattern.GetComponentsChildren<InventorySlot>();
    }

    void Update()
    {
        if(input.GetButtonDown("inventory"))
        {
            InventoryUI.setActive(!InventoryUI.ActiveSelf);
        }
    }

    void UpdateIU()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot;
            }
        }
    }
}