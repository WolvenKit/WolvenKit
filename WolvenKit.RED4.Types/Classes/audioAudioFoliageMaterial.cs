using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioFoliageMaterial : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("loopStart")] 
		public CName LoopStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("loopEnd")] 
		public CName LoopEnd
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
