using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimPlaySoundEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("soundEventName")] 
		public CName SoundEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
