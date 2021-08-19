using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISquadIsTracked : AIAIEvent
	{
		private CBool _isSquadTracked;

		[Ordinal(2)] 
		[RED("isSquadTracked")] 
		public CBool IsSquadTracked
		{
			get => GetProperty(ref _isSquadTracked);
			set => SetProperty(ref _isSquadTracked, value);
		}

		public AISquadIsTracked(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
