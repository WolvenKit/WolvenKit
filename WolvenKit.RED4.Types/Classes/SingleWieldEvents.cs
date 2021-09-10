using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SingleWieldEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] 
		[RED("hasInstantEquipHackBeenApplied")] 
		public CBool HasInstantEquipHackBeenApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
