using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWaterPatchNode : worldMeshNode
	{
		[Ordinal(18)] 
		[RED("type")] 
		public worldWaterPatchNodeType Type
		{
			get => GetPropertyValue<worldWaterPatchNodeType>();
			set => SetPropertyValue<worldWaterPatchNodeType>(value);
		}

		[Ordinal(19)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("generateNavmesh")] 
		public CBool GenerateNavmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldWaterPatchNode()
		{
			Type = new worldWaterPatchNodeType { TypeName = "Grid_100x100" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
