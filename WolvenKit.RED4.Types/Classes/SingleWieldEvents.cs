using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SingleWieldEvents : UpperBodyEventsTransition
	{
		private CBool _hasInstantEquipHackBeenApplied;

		[Ordinal(6)] 
		[RED("hasInstantEquipHackBeenApplied")] 
		public CBool HasInstantEquipHackBeenApplied
		{
			get => GetProperty(ref _hasInstantEquipHackBeenApplied);
			set => SetProperty(ref _hasInstantEquipHackBeenApplied, value);
		}
	}
}
