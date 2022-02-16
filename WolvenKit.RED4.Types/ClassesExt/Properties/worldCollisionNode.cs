namespace WolvenKit.RED4.Types;

public partial class worldCollisionNode
{
    [OrdinalOverride(Before = 15)]
    [RED("staticCollisionShapeCategories")]
    public worldStaticCollisionShapeCategories_CollisionNode StaticCollisionShapeCategories
    {
        get => GetPropertyValue<worldStaticCollisionShapeCategories_CollisionNode>();
        set => SetPropertyValue<worldStaticCollisionShapeCategories_CollisionNode>(value);
    }
}
