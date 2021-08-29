using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimPlaySoundEvent : inkanimEvent
	{
		private CName _soundEventName;

		[Ordinal(1)] 
		[RED("soundEventName")] 
		public CName SoundEventName
		{
			get => GetProperty(ref _soundEventName);
			set => SetProperty(ref _soundEventName, value);
		}
	}
}
