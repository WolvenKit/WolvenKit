using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NonStealthQuickHackVictimEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("instigatorID")] 
		public entEntityID InstigatorID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public NonStealthQuickHackVictimEvent()
		{
			InstigatorID = new();
		}
	}
}
