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
			Params = new physicsSystemBodyParams();
			LocalToModel = new Transform();
			CollisionShapes = new();
			MappedBoneToBody = new Transform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
