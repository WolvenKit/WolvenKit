using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SuppressNPCInSecuritySystem : redEvent
	{
		[Ordinal(0)] 
		[RED("suppressIncomingEvents")] 
		public CBool SuppressIncomingEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("suppressOutgoingEvents")] 
		public CBool SuppressOutgoingEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
