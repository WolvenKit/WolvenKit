using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRoadMaterialInfo : RedBaseClass
	{
		private CFloat _startOffset;
		private CEnum<worldRoadMaterial> _material;

		[Ordinal(0)] 
		[RED("startOffset")] 
		public CFloat StartOffset
		{
			get => GetProperty(ref _startOffset);
			set => SetProperty(ref _startOffset, value);
		}

		[Ordinal(1)] 
		[RED("material")] 
		public CEnum<worldRoadMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}
	}
}
