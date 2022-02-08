using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsStopTaggedSounds : redEvent
	{
		[Ordinal(0)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
