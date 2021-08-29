using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleePublicSafeEvents : MeleeEventsTransition
	{
		private CFloat _unequipTime;

		[Ordinal(0)] 
		[RED("unequipTime")] 
		public CFloat UnequipTime
		{
			get => GetProperty(ref _unequipTime);
			set => SetProperty(ref _unequipTime, value);
		}
	}
}
