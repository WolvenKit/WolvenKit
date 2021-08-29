using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioLoopedSoundEmitterMetadata : audioEmitterMetadata
	{
		private CName _loopSound;

		[Ordinal(1)] 
		[RED("loopSound")] 
		public CName LoopSound
		{
			get => GetProperty(ref _loopSound);
			set => SetProperty(ref _loopSound, value);
		}
	}
}
