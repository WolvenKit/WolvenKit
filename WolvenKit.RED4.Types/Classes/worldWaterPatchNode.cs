using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWaterPatchNode : worldMeshNode
	{
		[Ordinal(15)] 
		[RED("type")] 
		public worldWaterPatchNodeType Type
		{
			get => GetPropertyValue<worldWaterPatchNodeType>();
			set => SetPropertyValue<worldWaterPatchNodeType>(value);
		}

		[Ordinal(16)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldWaterPatchNode()
		{
			Type = new() { TypeName = "Grid_100x100" };
		}
	}
}
