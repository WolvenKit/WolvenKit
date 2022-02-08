using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollNotifyEnabledEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("instigator")] 
		public entEntityID Instigator
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public entRagdollNotifyEnabledEvent()
		{
			Instigator = new();
		}
	}
}
