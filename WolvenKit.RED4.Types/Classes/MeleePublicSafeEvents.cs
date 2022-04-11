using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleePublicSafeEvents : MeleeEventsTransition
	{
		[Ordinal(1)] 
		[RED("unequipTime")] 
		public CFloat UnequipTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
