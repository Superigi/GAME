using System.Diagnostics;
public class ItemPuckUp : Interacable
{
    public Item item;
    public override void Interact()
    {
        base.Interact();

        pickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPicked = Inventory.instance.add(item);
        if(wasPicked)
        {
            Destroy(gameObject);
        }
    }
}