using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsCustomFilterData : ISerializable
	{
		[Ordinal(0)] 
		[RED("collisionType")] 
		public CArray<CName> CollisionType
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("collideWith")] 
		public CArray<CName> CollideWith
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("queryDetect")] 
		public CArray<CName> QueryDetect
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public physicsCustomFilterData()
		{
			CollisionType = new();
			CollideWith = new();
			QueryDetect = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
