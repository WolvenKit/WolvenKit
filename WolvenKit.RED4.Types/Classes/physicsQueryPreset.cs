using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsQueryPreset : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("presetName")] 
		public CName PresetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
