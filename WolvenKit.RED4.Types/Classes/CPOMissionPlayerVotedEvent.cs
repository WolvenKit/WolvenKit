using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOMissionPlayerVotedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
