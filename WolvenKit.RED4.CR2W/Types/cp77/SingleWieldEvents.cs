using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SingleWieldEvents : UpperBodyEventsTransition
	{
		private CBool _hasInstantEquipHackBeenApplied;

		[Ordinal(6)] 
		[RED("hasInstantEquipHackBeenApplied")] 
		public CBool HasInstantEquipHackBeenApplied
		{
			get => GetProperty(ref _hasInstantEquipHackBeenApplied);
			set => SetProperty(ref _hasInstantEquipHackBeenApplied, value);
		}

		public SingleWieldEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
