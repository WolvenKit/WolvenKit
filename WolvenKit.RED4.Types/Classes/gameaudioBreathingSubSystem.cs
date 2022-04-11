using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioBreathingSubSystem : gameaudioISoundComponentSubSystem
	{
		[Ordinal(0)] 
		[RED("metadataName")] 
		public CName MetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
