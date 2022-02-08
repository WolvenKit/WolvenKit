using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAuxiliaryMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("physicalPropSettings")] 
		public CName PhysicalPropSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
