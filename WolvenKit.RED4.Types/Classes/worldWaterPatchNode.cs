using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWaterPatchNode : worldMeshNode
	{
		private worldWaterPatchNodeType _type;
		private CFloat _depth;

		[Ordinal(15)] 
		[RED("type")] 
		public worldWaterPatchNodeType Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(16)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get => GetProperty(ref _depth);
			set => SetProperty(ref _depth, value);
		}
	}
}
