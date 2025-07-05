using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SvgResource : CResource
	{
		[Ordinal(1)] 
		[RED("vectorGraphicDef")] 
		public CHandle<vgVectorGraphicDefinition> VectorGraphicDef
		{
			get => GetPropertyValue<CHandle<vgVectorGraphicDefinition>>();
			set => SetPropertyValue<CHandle<vgVectorGraphicDefinition>>(value);
		}

		public SvgResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
