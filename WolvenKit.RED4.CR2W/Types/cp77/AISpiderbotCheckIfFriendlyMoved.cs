using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpiderbotCheckIfFriendlyMoved : AIAutonomousConditions
	{
		private CHandle<AIArgumentMapping> _maxAllowedDelta;

		[Ordinal(0)] 
		[RED("maxAllowedDelta")] 
		public CHandle<AIArgumentMapping> MaxAllowedDelta
		{
			get => GetProperty(ref _maxAllowedDelta);
			set => SetProperty(ref _maxAllowedDelta, value);
		}

		public AISpiderbotCheckIfFriendlyMoved(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
