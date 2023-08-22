using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsSystemBody : physicsISystemObject
	{
		[Ordinal(1)] 
		[RED("params")] 
		public physicsSystemBodyParams Params
		{
			get => GetPropertyValue<physicsSystemBodyParams>();
			set => SetPropertyValue<physicsSystemBodyParams>(value);
		}

		[Ordinal(2)] 
		[RED("localToModel")] 
		public Transform LocalToModel
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(3)] 
		[RED("collisionShapes")] 
		public CArray<CHandle<physicsICollider>> CollisionShapes
		{
			get => GetPropertyValue<CArray<CHandle<physicsICollider>>>();
			set => SetPropertyValue<CArray<CHandle<physicsICollider>>>(value);
		}

		[Ordinal(4)] 
		[RED("mappedBoneName")] 
		public CName MappedBoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("mappedBoneToBody")] 
		public Transform MappedBoneToBody
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(6)] 
		[RED("isQueryBodyOnly")] 
		public CBool IsQueryBodyOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public physicsSystemBody()
		{
			Params = new physicsSystemBodyParams { SimulationType = Enums.physicsSimulationType.Dynamic, SolverIterationsCountPosition = 4, SolverIterationsCountVelocity = 1, MaxDepenetrationVelocity = -1.000000F, MaxAngularVelocity = -1.000000F, MaxContactImpulse = -1.000000F, Inertia = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, ComOffset = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } } };
			LocalToModel = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			CollisionShapes = new();
			MappedBoneToBody = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
