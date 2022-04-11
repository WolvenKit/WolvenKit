using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReadyEvents : WeaponEventsTransition
	{
		[Ordinal(3)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
