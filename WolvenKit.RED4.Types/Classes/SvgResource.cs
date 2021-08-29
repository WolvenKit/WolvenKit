using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SvgResource : CResource
	{
		private CHandle<vgVectorGraphicDefinition> _vectorGraphicDef;

		[Ordinal(1)] 
		[RED("vectorGraphicDef")] 
		public CHandle<vgVectorGraphicDefinition> VectorGraphicDef
		{
			get => GetProperty(ref _vectorGraphicDef);
			set => SetProperty(ref _vectorGraphicDef, value);
		}
	}
}
