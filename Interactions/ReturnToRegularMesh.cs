public class ReturnToRegularMesh
{
    [ContextMenu("Convert to regular mesh")]
    void Convert()
    {
        SkinnedMeshRender skinnedMeshRender = GetComponent<SkinnedMeshRender>();
        skinnedMeshRender meshRender = gameObject.AddComponent<MeshRender>();
        MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();

        meshFilter.sharedMesh = skinnedMeshRender.sharedMaterials;
        meshRender.sharedMaterials = skinnedMeshRender.sharedMaterials;

        DestroyImmediate(skinnedMeshRender);
        DestroyImmediate(this);
    }
}