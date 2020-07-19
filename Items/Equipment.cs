using System.Runtime.Intrinsics.Arm.Arm64;

[CreateAssetMenu(fillName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    public EquipmentSlot equipSlot;   
    public SkinnedMeshRender mesh;
    public EquipmentMeshRegion[] corveredMeshRegion;
    public int armourModified;
    public int demageMofied;

    public override void use()
    {
        Base.use();
        EquipmentMenager.instance.Equip(this);
        RemoveFromInvantory();
    }
}

public enum EquipmentSlot {Head, Chest, Legs, Weapon, Shiels, Feet}
public enum EquipmentMeshRegion {Legs, Arms, Torso}