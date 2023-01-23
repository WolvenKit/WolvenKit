using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLoopedSoundEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("loopSound")] 
		public CName LoopSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioLoopedSoundEmitterMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
