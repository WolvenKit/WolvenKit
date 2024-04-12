namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsPhysicsActor : physicsPhysicsBase
{
    [Ordinal(4)]
    [RED("actorCOM")]
    [REDProperty(IsIgnored = true)]
    public CHandle<physicsEditorActorCOM> ActorCOM
    {
        get => GetPropertyValue<CHandle<physicsEditorActorCOM>>();
        set => SetPropertyValue<CHandle<physicsEditorActorCOM>>(value);
    }

    [Ordinal(5)]
    [RED("shapes")]
    [REDProperty(IsIgnored = true)]
    public CArray<CHandle<physicsPhysicsShape>> Shapes
    {
        get => GetPropertyValue<CArray<CHandle<physicsPhysicsShape>>>();
        set => SetPropertyValue<CArray<CHandle<physicsPhysicsShape>>>(value);
    }

    [Ordinal(6)]
    [RED("simType")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsSimulation> SimType
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsSimulation>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsSimulation>>(value);
    }

    [Ordinal(7)]
    [RED("meshBoneMap")]
    [REDProperty(IsIgnored = true)]
    public physicsPhysicsMeshBoneMapping MeshBoneMap
    {
        get => GetPropertyValue<physicsPhysicsMeshBoneMapping>();
        set => SetPropertyValue<physicsPhysicsMeshBoneMapping>(value);
    }

    [Ordinal(8)]
    [RED("linearDamping")]
    [REDProperty(IsIgnored = true)]
    public CFloat LinearDamping
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(9)]
    [RED("angularDamping")]
    [REDProperty(IsIgnored = true)]
    public CFloat AngularDamping
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(10)]
    [RED("solverIterationsCountPosition")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 SolverIterationsCountPosition
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(11)]
    [RED("solverIterationsCountVelocity")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 SolverIterationsCountVelocity
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(12)]
    [RED("maxAngularVelocity")]
    [REDProperty(IsIgnored = true)]
    public CFloat MaxAngularVelocity
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(13)]
    [RED("maxDepenetrationVelocity")]
    [REDProperty(IsIgnored = true)]
    public CFloat MaxDepenetrationVelocity
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(14)]
    [RED("maxContactImpulse")]
    [REDProperty(IsIgnored = true)]
    public CFloat MaxContactImpulse
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(15)]
    [RED("isQueryOnlyActor")]
    [REDProperty(IsIgnored = true)]
    public CBool IsQueryOnlyActor
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    public physicsPhysicsActor()
    {
        BaseType = physicsEPhysicsBaseType.Actor;
    }
}