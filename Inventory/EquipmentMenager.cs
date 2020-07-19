using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
public class EquipmentMenager
{
    #region Singeletion
    public static EquipmentMenager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public Equipment[] deafultItems;
    public SkinnedMeshRender targetMesh;
    Equipment[] currentEquipment;
    SkinnedMeshRender[] currentMeshes;

    public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
    public OnEquipmentChanged onEquipmentChanged;

    Inventory inventory;

    void start()
    {
        Inventory = Inventory.instance;
        int numSlot = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new Equipment[numSlot];
        currentMeshes = new SkinnedMeshRender[numSlot];

        EquipDeafultItems();
    }

    public void Equip(Equipment newItem)
    {
        int slotIndex = (int)newItem.equipSlot;
        Equipment = oldItem = Unequip(slotIndex);;

        if(currentEquipment[indexSlot] != null)
        {
            oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);  
        }

        currentEquipment[slotIndex] = newItem;
        SkinnedMeshRender newMesh = Instantiate<SkinnedMeshRender>(newItem.mesh);
        newMesh.transform.parent = targetMesh.transform;
        
        newMesh.bones = targetMesh.bones;
        newMesh.rootBone = targetMesh.rootBone;
        currentMeshes[slotIndex] = newMesh;

        if(onEquipmentChanged != null)
        {
            onEquipmentChanged.Invoke(newItem, oldItem);
        }

        SetEquipBlendShapes(newItem, 100);
    }
    public Equipment Unequip(int slotIndex)
    {
       if(currentEquipment[slotIndex] != null)
        {    
            if(currentMeshes[slotIndex] != null)
            {
                Destroy(currentMeshes[slotIndex].gameObject);
            }

            Equipment oldItem = currentEquipment[slotIndex];
            SetEquipBlendShapes(oldItem, 0);
            inventory.Add(oldItem);
            currentEquipment[slotIndex] = null;
        
            if(onEquipmentChanged != null)
            {
                onEquipmentChanged.Invoke(null, oldItem);
            }

            return oldItem;
        }

        return null;
    }

    public void UnequipAll()
    {
        for(int i = 0; i < currentEquipment.Length; i++)
        {
            Unequip(i);
        }
        EquipDeafultItems();
    }

    void SetEquipBlendShapes(Equipment item, int weight)
    {
        foreach(EquipmentMeshRegion blendShape in item.corveredMeshRegion)
        {
            targetMesh.SetBlendShapesWeight((int)blendShape, weight);
        }
    }

    void EquipDeafultItems()
    {
        foreach(Equipment item in deafultItems)
        {
            Equip(item);
        }
    }

    void update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            UnequipAll();
        }
    }
}