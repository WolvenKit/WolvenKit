using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutomaticDeescalationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("originalNotification")] 
		public CHandle<SecuritySystemInput> OriginalNotification
		{
			get => GetPropertyValue<CHandle<SecuritySystemInput>>();
			set => SetPropertyValue<CHandle<SecuritySystemInput>>(value);
		}
	}
}
