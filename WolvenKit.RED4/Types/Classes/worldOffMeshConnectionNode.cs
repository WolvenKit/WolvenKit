using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldOffMeshConnectionNode : worldSplineNode
	{
		[Ordinal(9)] 
		[RED("isBidirectional")] 
		public CBool IsBidirectional
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<worldOffMeshConnectionType> Type
		{
			get => GetPropertyValue<CEnum<worldOffMeshConnectionType>>();
			set => SetPropertyValue<CEnum<worldOffMeshConnectionType>>(value);
		}

		[Ordinal(12)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public worldOffMeshConnectionNode()
		{
			Radius = 1.000000F;
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
