using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsCollisionPresetDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("ForceEnableCollisionCallbacks")] 
		public CBool ForceEnableCollisionCallbacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("CollisionType")] 
		public CArray<CName> CollisionType
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("CollisionMask")] 
		public CArray<CName> CollisionMask
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("QueryDetect")] 
		public CArray<CName> QueryDetect
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public physicsCollisionPresetDefinition()
		{
			CollisionType = new();
			CollisionMask = new();
			QueryDetect = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
