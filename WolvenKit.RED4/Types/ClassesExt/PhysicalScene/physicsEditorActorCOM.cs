namespace WolvenKit.RED4.Types.PhysicalScene;

public class physicsEditorActorCOM : physicsPhysicsBase
{
    [Ordinal(4)]
    [RED("comOffset")]
    [REDProperty(IsIgnored = true)]
    public Transform ComOffset
    {
        get => GetPropertyValue<Transform>();
        set => SetPropertyValue<Transform>(value);
    }

    [Ordinal(5)]
    [RED("inertia")]
    [REDProperty(IsIgnored = true)]
    public Vector3 Inertia
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [Ordinal(6)]
    [RED("volume")]
    [REDProperty(IsIgnored = true)]
    public CFloat Volume
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(7)]
    [RED("mass")]
    [REDProperty(IsIgnored = true)]
    public CFloat Mass
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(8)]
    [RED("parentLocalToWorld")]
    [REDProperty(IsIgnored = true)]
    public CMatrix ParentLocalToWorld
    {
        get => GetPropertyValue<CMatrix>();
        set => SetPropertyValue<CMatrix>(value);
    }
}